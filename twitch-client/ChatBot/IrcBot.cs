﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using TwitchClient.Util;

namespace TwitchClient.ChatBot
{
    internal class IrcBot
    {
        // TODO throttle writing
        // TODO error handling, handle ping timeouts, reconnecting, etc
        // TODO add twitch emotes/rank images (turbo, mod, etc) to rtb

        private const string CommandPrefix = "!";
        private const int EchoCommandCooldown = 35000;
        private const int RandomNotificationCooldown = 120000;
        private const int MaxChatBoxLines = 1000;
        public static Dictionary<string, string> EchoCommands = new Dictionary<string, string>();
        public static Dictionary<string, int> EchoCommandsCooldown = new Dictionary<string, int>();
        public static List<string> RandomNotifications = new List<string>();
        private readonly TcpClient _client;
        private readonly MainForm _masterForm;
        private readonly Random _random = new Random();
        private string _channel;
        private int _lastPing;
        private int _lastRandomNotification;
        private int _lastServerPing;
        private string _nickname;
        private string _password;
        private StreamReader _reader;
        private Thread _thread;
        private StreamWriter _writer;

        public IrcBot(MainForm master)
        {
            // Initialising socket
            _client = new TcpClient();
            _masterForm = master;
        }

        #region Core functionality

        public bool Initialize(string nickname, string password, string channel, string hostname, int port)
        {
            // TODO handle reconnects
            // Setting variables
            _channel = channel.StartsWith("#") ? channel : "#" + channel;
            _nickname = nickname;
            _password = password;

#if DEBUG
            Debug.WriteLine("Chat bot initialized with settings: (nick:" + _nickname + ",channel:" + _channel + ",host:" +
                            hostname + ",port:" + port + ")");
#endif

            try
            {
                _client.Connect(hostname, port);
                _writer = new StreamWriter(_client.GetStream());
                _reader = new StreamReader(_client.GetStream());
                Connected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unhandled critical error occured while trying to connect the IRC bot to the Twitch IRC server." +
                    Environment.NewLine
                    + "Error Message: " + ex.Message, "IRC Bot - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Terminating session since critical error
                if (_client.Connected)
                    _client.Close();
                Connected = false;
                return false;
            }

            // Initialising operational threads
            _thread = new Thread(Run)
            {
                Name = "CHANBOT_PROCESSING_THREAD"
            };
            _thread.Start();
            return true;
        }

        public void Run()
        {
            // Initialising session
            _lastPing = _lastServerPing = _lastRandomNotification = Environment.TickCount;
            _writer.WriteLine("PASS " + _password);
            _writer.WriteLine("NICK " + _nickname);
            _writer.WriteLine("JOIN " + _channel);
            _writer.Flush();

#if DEBUG
            Debug.WriteLine("Chat bot is now connecting.");
#endif
            // Stalling for connection response
            string line = String.Empty;
            bool success = true;

            while (!String.IsNullOrEmpty((line = _reader.ReadLine())))
            {
                // On-connect message - :tmi.twitch.tv 001 <nickname> :<welcome message>
                if (line.Contains("001"))
                {
                    break;
                }

                // Invalid password - :tmi.twitch.tv NOTICE * :Error logging in
                if (line.Contains("Error logging in"))
                {
                    MessageBox.Show("Invalid password for channel bot - connection terminated by twitch.", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                    break;
                }
            }

            // Checking if an error occured in the previous step
            if (!success || !_client.Connected)
            {
                Debug.WriteLine("Chat bot connection terminated.");
                return;
            }

#if DEBUG
            Debug.WriteLine("Chat bot is now connected.");
#endif
            AppendText("Chat bot is now connected.");

            // Read loop
            int restTimer = 5;

            while (Connected)
            {
                ProcessLoop();

                // Processing line if there is any thing to read
                if (_client.Available > 0 || _reader.Peek() != -1) // XXX latter condition useless?
                {
                    ProcessLine(_reader.ReadLine());
                }

                // Throttling processing to reduce CPU load
                if (restTimer-- == 5)
                {
                    Thread.Sleep(1);
                    restTimer = 5;
                }
            }
        }

        private void ProcessLoop()
        {
            // Ping-pong initiation
            if (Environment.TickCount - _lastPing > 25000)
            {
                WriteLineFlush("PING LAG" + DateHelper.UnixTimestampNow());
                _lastPing = Environment.TickCount;
            }

            // Checking if we should spit a random notification
            if (RandomNotifications.Count > 0 &&
                Environment.TickCount - _lastRandomNotification > RandomNotificationCooldown)
            {
                lock (RandomNotifications)
                {
                    SendMessageFlush(RandomNotifications[_random.Next(RandomNotifications.Count)]);
                }
                _lastRandomNotification = Environment.TickCount;
            }
        }

        private void ProcessLine(string line)
        {
            if (String.IsNullOrEmpty(line))
                return;

#if DEBUG
            // Debug.WriteLine(">> " + line);
#endif

            // Normalising line
            if (line.StartsWith(":"))
            {
                line = line.Substring(1);
            }

            // Ping-pong response
            if (line.StartsWith("PING"))
            {
                WriteLineFlush(line.Replace("PING", "PONG"));
                _lastServerPing = Environment.TickCount;
            }

            if (line.StartsWith("PONG"))
            {
                _lastServerPing = Environment.TickCount;
            }

            // Regular message parsing
            string[] explode = line.Split(' ');


            if (explode.Length < 2)
                return;
            string sender = explode[0];
            string command = explode[1];

            switch (command) // XXX make an OOP command handler
            {
                case "353": // Initial users list
                    string users = line.Substring(line.IndexOf(':') + 1);
                    string[] nickList = users.Split(' ');

                    foreach (string nickname in nickList)
                    {
                        AddUser(nickname);
                    }
                    break;
                case "JOIN":
                    // Parsing input
                    string nick = sender.Substring(0, sender.IndexOf('!'));

                    // Updating UI
                    AppendTextPrefixNewLine("* Join: " + nick);
                    AddUser(nick);
                    break;
                case "PART":
                    // Parsing input
                    nick = sender.Substring(0, sender.IndexOf('!'));

                    // Updating UI
                    AppendTextPrefixNewLine("* Part: " + nick);
                    RemoveUser(nick);
                    RemoveUser("@" + nick);
                    break;
                case "MODE":
                    // jtv MODE {channel} {mode} {nick}
                    nick = explode[4];

                    switch (explode[3])
                    {
                        case "+o": // Give mod
                            RemoveUser(nick);
                            AddUser("@" + nick);
                            AppendTextPrefixNewLine("* Modded: " + nick);

                            // Checking if we were modded, if so enabling the mod context menu for the users list
                            if (nick.Equals(_nickname, StringComparison.CurrentCultureIgnoreCase))
                            {
                                _masterForm.SetUsersListContextMenuItemsEnabled(true);
                            }
                            break;
                        case "-o": // Remove mod
                            RemoveUser("@" + nick);
                            AddUser(nick);
                            AppendTextPrefixNewLine("* Unmodded: " + nick);
                            break;
                    }
                    break;
                case "PRIVMSG":
                    // Parsing input
                    nick = sender.Substring(0, sender.IndexOf('!'));
                    int messageStartIndex = line.IndexOf(':') + 1;
                    string message = line.Substring(messageStartIndex);

                    // Updating UI
                    AppendTextPrefixNewLine(String.Format("<{0}> {1}", nick, message));

                    // Replying to message if necessary
                    if (message.StartsWith(CommandPrefix))
                    {
                        // Echo commands
                        message = message.Substring(CommandPrefix.Length); // removing the command prefix

                        lock (EchoCommands)
                        {
                            // Checking if the command exists
                            if (EchoCommands.ContainsKey(message))
                            {
                                int deltaTime = Environment.TickCount - EchoCommandsCooldown[message];

                                if (deltaTime > EchoCommandCooldown)
                                {
                                    SendMessageFlush(EchoCommands[message]);
                                    EchoCommandsCooldown[message] = Environment.TickCount;
                                }
                            }
                        }
                    }
                    break;
            }
        }

        #endregion

        #region Socket Writing

        public void SendMessageFlush(string message)
        {
            // PRIVMSG <channel> :<msg>
            WriteLineFlush("PRIVMSG " + _channel + " :" + message);
        }

        public void SendTimeout(string user, string time = "")
        {
            if (user.Length == 0)
                return;
            if (user.StartsWith("@"))
                user = user.Substring(1);
            SendMessageFlush(".timeout " + user + (time.Length == 0 ? "" : " " + time));
        }

        public void SendBan(string user)
        {
            if (user.Length == 0)
                return;
            if (user.StartsWith("@"))
                return; // cant ban mods
            SendMessageFlush(".ban " + user);
        }

        public void SendUnban(string user)
        {
            if (user.Length == 0)
                return;
            SendMessageFlush(".unban " + user);
        }

        private void WriteLineFlush(string line)
        {
            try
            {
                // Writing line
                _writer.WriteLine(line);
                _writer.Flush();

                // Adding line to rtb if necessary
                if (line.StartsWith("PRIVMSG "))
                {
                    int colonIndex = line.IndexOf(':') + 1;
                    string msg = line.Substring(colonIndex);
                    AppendTextPrefixNewLine(String.Format("<{0}> {1}", _nickname, msg));
                }
            }
            catch (Exception e)
            {
                if (!_client.Connected)
                {
                    Connected = false;
                    MessageBox.Show(
                        "The IRC server connection was terminated during a message write event." + Environment.NewLine +
                        "Error Message: " + e.Message, "IRC Bot - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region UI manipulation

        private void AppendText(string text)
        {
            _AppendText(String.Format("[{0}] {1}", DateTime.Now, text));
        }

        private void AppendTextPrefixNewLine(string text)
        {
            _AppendText(String.Format("{2}[{0}] {1}", DateTime.Now, text, Environment.NewLine));
        }

        private void _AppendText(string text)
        {
            _masterForm.ChatRichTextBox.Invoke((MethodInvoker) (() =>
            {
                _masterForm.ChatRichTextBox.Text += text; // to avoid scrolling to end, like when using (RTB).AppendText

                // Scrolling to end of rtb if not focused (i.e. if the user is not fiddling with it)
                if (_masterForm.ChatRichTextBox.Focused)
                    return;
                _masterForm.ChatRichTextBox.SelectionStart = _masterForm.ChatRichTextBox.Text.Length;
                _masterForm.ChatRichTextBox.ScrollToCaret();

                // Trimming lines if too many are present, in batches to not lock up the UI
                int maxCycles = 5;

                while (_masterForm.ChatRichTextBox.Lines.Length > MaxChatBoxLines && (maxCycles--) != 0)
                {
                    // XXX find a proper work around, this one is sufficient for now
                    _masterForm.ChatRichTextBox.ReadOnly = false; // rtf is readonly, we must change this
                    _masterForm.ChatRichTextBox.SelectionStart = 0;
                    _masterForm.ChatRichTextBox.SelectionLength = _masterForm.ChatRichTextBox.Text.IndexOf('\n') + 1;
                    _masterForm.ChatRichTextBox.SelectedText = "";
                    _masterForm.ChatRichTextBox.ReadOnly = true;
                }
            }));
        }

        private void AddUser(string nickname)
        {
            _masterForm.ChatUsersListBox.Invoke((MethodInvoker) (() =>
            {
                if (!_masterForm.ChatUsersListBox.Items.Contains(nickname))
                    _masterForm.ChatUsersListBox.Items.Add(nickname);
            }));
        }

        private void RemoveUser(string nickname)
        {
            _masterForm.ChatUsersListBox.Invoke((MethodInvoker) (() =>
            {
                if (_masterForm.ChatUsersListBox.Items.Contains(nickname))
                    _masterForm.ChatUsersListBox.Items.Remove(nickname);
            }));
        }

        #endregion

        public bool Connected { get; private set; }
    }
}