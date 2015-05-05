﻿using TwitchClient.Panels.Broadcasting;

namespace TwitchClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.masterStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainStatsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.masterMenuStrip = new System.Windows.Forms.MenuStrip();
            this.updatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleMainStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleFollowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.broadcastingTabPage = new System.Windows.Forms.TabPage();
            this.followersTextBox = new System.Windows.Forms.TextBox();
            this.watchStreamPanel = new TwitchClient.Panels.Broadcasting.WatchStreamPanel();
            this.updateBroadcastingInfoPanel = new TwitchClient.Panels.Broadcasting.UpdateBroadcastingInfoPanel();
            this.broadcastingInfoPanel = new TwitchClient.Panels.Broadcasting.BroadcastingInfoPanel();
            this.chatBotTabPage = new System.Windows.Forms.TabPage();
            this.chatBotSplitContainer = new System.Windows.Forms.SplitContainer();
            this.chatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.chatUsersListBox = new System.Windows.Forms.ListBox();
            this.chatBotSettingsTabPage = new System.Windows.Forms.TabPage();
            this.chatBotSettingsTabControl = new System.Windows.Forms.TabControl();
            this.chatBotCredsTabPage = new System.Windows.Forms.TabPage();
            this.chatBotCredentialsPanel = new TwitchClient.Panels.ChatBot.ChatBotCredentialsPanel();
            this.echoCommandsTabPage = new System.Windows.Forms.TabPage();
            this.addEchoCommandButton = new System.Windows.Forms.Button();
            this.newEchoCommandTextBox = new System.Windows.Forms.TextBox();
            this.echoCommandsListBox = new System.Windows.Forms.ListBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.followersUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.randomNotificationsTabPage = new System.Windows.Forms.TabPage();
            this.addRandomNotificationButton = new System.Windows.Forms.Button();
            this.newRandomNotificationTextBox = new System.Windows.Forms.TextBox();
            this.randomNotificationsListBox = new System.Windows.Forms.ListBox();
            this.masterStatusStrip.SuspendLayout();
            this.masterMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.broadcastingTabPage.SuspendLayout();
            this.chatBotTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chatBotSplitContainer)).BeginInit();
            this.chatBotSplitContainer.Panel1.SuspendLayout();
            this.chatBotSplitContainer.Panel2.SuspendLayout();
            this.chatBotSplitContainer.SuspendLayout();
            this.chatBotSettingsTabPage.SuspendLayout();
            this.chatBotSettingsTabControl.SuspendLayout();
            this.chatBotCredsTabPage.SuspendLayout();
            this.echoCommandsTabPage.SuspendLayout();
            this.randomNotificationsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterStatusStrip
            // 
            this.masterStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatsLabel});
            this.masterStatusStrip.Location = new System.Drawing.Point(0, 423);
            this.masterStatusStrip.Name = "masterStatusStrip";
            this.masterStatusStrip.Size = new System.Drawing.Size(549, 22);
            this.masterStatusStrip.TabIndex = 0;
            // 
            // mainStatsLabel
            // 
            this.mainStatsLabel.Name = "mainStatsLabel";
            this.mainStatsLabel.Size = new System.Drawing.Size(73, 17);
            this.mainStatsLabel.Text = "Main Stats: ?";
            // 
            // masterMenuStrip
            // 
            this.masterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatingToolStripMenuItem});
            this.masterMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.masterMenuStrip.Name = "masterMenuStrip";
            this.masterMenuStrip.Size = new System.Drawing.Size(549, 24);
            this.masterMenuStrip.TabIndex = 1;
            // 
            // updatingToolStripMenuItem
            // 
            this.updatingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleMainStatsToolStripMenuItem,
            this.toggleFollowersToolStripMenuItem});
            this.updatingToolStripMenuItem.Name = "updatingToolStripMenuItem";
            this.updatingToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.updatingToolStripMenuItem.Text = "Updating";
            // 
            // toggleMainStatsToolStripMenuItem
            // 
            this.toggleMainStatsToolStripMenuItem.Checked = true;
            this.toggleMainStatsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleMainStatsToolStripMenuItem.Name = "toggleMainStatsToolStripMenuItem";
            this.toggleMainStatsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.toggleMainStatsToolStripMenuItem.Text = "Main Stats";
            this.toggleMainStatsToolStripMenuItem.Click += new System.EventHandler(this.mainStatsToolStripMenuItem_Click);
            // 
            // toggleFollowersToolStripMenuItem
            // 
            this.toggleFollowersToolStripMenuItem.Checked = true;
            this.toggleFollowersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleFollowersToolStripMenuItem.Name = "toggleFollowersToolStripMenuItem";
            this.toggleFollowersToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.toggleFollowersToolStripMenuItem.Text = "Followers";
            this.toggleFollowersToolStripMenuItem.Click += new System.EventHandler(this.followersToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.broadcastingTabPage);
            this.tabControl.Controls.Add(this.chatBotTabPage);
            this.tabControl.Controls.Add(this.chatBotSettingsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(549, 399);
            this.tabControl.TabIndex = 2;
            // 
            // broadcastingTabPage
            // 
            this.broadcastingTabPage.Controls.Add(this.followersTextBox);
            this.broadcastingTabPage.Controls.Add(this.watchStreamPanel);
            this.broadcastingTabPage.Controls.Add(this.updateBroadcastingInfoPanel);
            this.broadcastingTabPage.Controls.Add(this.broadcastingInfoPanel);
            this.broadcastingTabPage.Location = new System.Drawing.Point(4, 22);
            this.broadcastingTabPage.Name = "broadcastingTabPage";
            this.broadcastingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.broadcastingTabPage.Size = new System.Drawing.Size(541, 373);
            this.broadcastingTabPage.TabIndex = 0;
            this.broadcastingTabPage.Text = "Broadcasting";
            this.broadcastingTabPage.UseVisualStyleBackColor = true;
            // 
            // followersTextBox
            // 
            this.followersTextBox.Location = new System.Drawing.Point(346, 3);
            this.followersTextBox.Multiline = true;
            this.followersTextBox.Name = "followersTextBox";
            this.followersTextBox.Size = new System.Drawing.Size(192, 147);
            this.followersTextBox.TabIndex = 4;
            // 
            // watchStreamPanel
            // 
            this.watchStreamPanel.Location = new System.Drawing.Point(3, 156);
            this.watchStreamPanel.Name = "watchStreamPanel";
            this.watchStreamPanel.Size = new System.Drawing.Size(535, 211);
            this.watchStreamPanel.TabIndex = 2;
            // 
            // updateBroadcastingInfoPanel
            // 
            this.updateBroadcastingInfoPanel.Location = new System.Drawing.Point(3, 69);
            this.updateBroadcastingInfoPanel.Name = "updateBroadcastingInfoPanel";
            this.updateBroadcastingInfoPanel.Size = new System.Drawing.Size(337, 81);
            this.updateBroadcastingInfoPanel.TabIndex = 1;
            // 
            // broadcastingInfoPanel
            // 
            this.broadcastingInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.broadcastingInfoPanel.Name = "broadcastingInfoPanel";
            this.broadcastingInfoPanel.Size = new System.Drawing.Size(300, 60);
            this.broadcastingInfoPanel.TabIndex = 0;
            // 
            // chatBotTabPage
            // 
            this.chatBotTabPage.Controls.Add(this.chatBotSplitContainer);
            this.chatBotTabPage.Location = new System.Drawing.Point(4, 22);
            this.chatBotTabPage.Name = "chatBotTabPage";
            this.chatBotTabPage.Size = new System.Drawing.Size(541, 373);
            this.chatBotTabPage.TabIndex = 1;
            this.chatBotTabPage.Text = "Chat Bot";
            this.chatBotTabPage.UseVisualStyleBackColor = true;
            // 
            // chatBotSplitContainer
            // 
            this.chatBotSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatBotSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.chatBotSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.chatBotSplitContainer.Name = "chatBotSplitContainer";
            // 
            // chatBotSplitContainer.Panel1
            // 
            this.chatBotSplitContainer.Panel1.Controls.Add(this.chatRichTextBox);
            // 
            // chatBotSplitContainer.Panel2
            // 
            this.chatBotSplitContainer.Panel2.Controls.Add(this.chatUsersListBox);
            this.chatBotSplitContainer.Size = new System.Drawing.Size(541, 373);
            this.chatBotSplitContainer.SplitterDistance = 413;
            this.chatBotSplitContainer.TabIndex = 1;
            // 
            // chatRichTextBox
            // 
            this.chatRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.chatRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatRichTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.chatRichTextBox.Name = "chatRichTextBox";
            this.chatRichTextBox.ReadOnly = true;
            this.chatRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.chatRichTextBox.Size = new System.Drawing.Size(413, 373);
            this.chatRichTextBox.TabIndex = 0;
            this.chatRichTextBox.Text = "";
            // 
            // chatUsersListBox
            // 
            this.chatUsersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatUsersListBox.FormattingEnabled = true;
            this.chatUsersListBox.Location = new System.Drawing.Point(0, 0);
            this.chatUsersListBox.Name = "chatUsersListBox";
            this.chatUsersListBox.Size = new System.Drawing.Size(124, 373);
            this.chatUsersListBox.TabIndex = 0;
            // 
            // chatBotSettingsTabPage
            // 
            this.chatBotSettingsTabPage.Controls.Add(this.chatBotSettingsTabControl);
            this.chatBotSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.chatBotSettingsTabPage.Name = "chatBotSettingsTabPage";
            this.chatBotSettingsTabPage.Size = new System.Drawing.Size(541, 373);
            this.chatBotSettingsTabPage.TabIndex = 2;
            this.chatBotSettingsTabPage.Text = "Chat Bot Settings";
            this.chatBotSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // chatBotSettingsTabControl
            // 
            this.chatBotSettingsTabControl.Controls.Add(this.chatBotCredsTabPage);
            this.chatBotSettingsTabControl.Controls.Add(this.echoCommandsTabPage);
            this.chatBotSettingsTabControl.Controls.Add(this.randomNotificationsTabPage);
            this.chatBotSettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatBotSettingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.chatBotSettingsTabControl.Name = "chatBotSettingsTabControl";
            this.chatBotSettingsTabControl.SelectedIndex = 0;
            this.chatBotSettingsTabControl.Size = new System.Drawing.Size(541, 373);
            this.chatBotSettingsTabControl.TabIndex = 0;
            // 
            // chatBotCredsTabPage
            // 
            this.chatBotCredsTabPage.Controls.Add(this.chatBotCredentialsPanel);
            this.chatBotCredsTabPage.Location = new System.Drawing.Point(4, 22);
            this.chatBotCredsTabPage.Name = "chatBotCredsTabPage";
            this.chatBotCredsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.chatBotCredsTabPage.Size = new System.Drawing.Size(533, 347);
            this.chatBotCredsTabPage.TabIndex = 0;
            this.chatBotCredsTabPage.Text = "Bot Credentials";
            this.chatBotCredsTabPage.UseVisualStyleBackColor = true;
            // 
            // chatBotCredentialsPanel
            // 
            this.chatBotCredentialsPanel.Location = new System.Drawing.Point(6, 6);
            this.chatBotCredentialsPanel.Name = "chatBotCredentialsPanel";
            this.chatBotCredentialsPanel.Size = new System.Drawing.Size(297, 112);
            this.chatBotCredentialsPanel.TabIndex = 0;
            // 
            // echoCommandsTabPage
            // 
            this.echoCommandsTabPage.Controls.Add(this.addEchoCommandButton);
            this.echoCommandsTabPage.Controls.Add(this.newEchoCommandTextBox);
            this.echoCommandsTabPage.Controls.Add(this.echoCommandsListBox);
            this.echoCommandsTabPage.Location = new System.Drawing.Point(4, 22);
            this.echoCommandsTabPage.Name = "echoCommandsTabPage";
            this.echoCommandsTabPage.Size = new System.Drawing.Size(533, 347);
            this.echoCommandsTabPage.TabIndex = 1;
            this.echoCommandsTabPage.Text = "Echo Commands";
            this.echoCommandsTabPage.UseVisualStyleBackColor = true;
            // 
            // addEchoCommandButton
            // 
            this.addEchoCommandButton.Location = new System.Drawing.Point(297, 180);
            this.addEchoCommandButton.Name = "addEchoCommandButton";
            this.addEchoCommandButton.Size = new System.Drawing.Size(75, 23);
            this.addEchoCommandButton.TabIndex = 2;
            this.addEchoCommandButton.Text = "Add";
            this.addEchoCommandButton.UseVisualStyleBackColor = true;
            this.addEchoCommandButton.Click += new System.EventHandler(this.addEchoCommandButton_Click);
            // 
            // newEchoCommandTextBox
            // 
            this.newEchoCommandTextBox.Location = new System.Drawing.Point(4, 182);
            this.newEchoCommandTextBox.Name = "newEchoCommandTextBox";
            this.newEchoCommandTextBox.Size = new System.Drawing.Size(287, 20);
            this.newEchoCommandTextBox.TabIndex = 1;
            this.newEchoCommandTextBox.Text = "command name:message to echo";
            // 
            // echoCommandsListBox
            // 
            this.echoCommandsListBox.FormattingEnabled = true;
            this.echoCommandsListBox.Location = new System.Drawing.Point(4, 3);
            this.echoCommandsListBox.Name = "echoCommandsListBox";
            this.echoCommandsListBox.Size = new System.Drawing.Size(368, 173);
            this.echoCommandsListBox.TabIndex = 0;
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 2500;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // followersUpdateTimer
            // 
            this.followersUpdateTimer.Interval = 5000;
            this.followersUpdateTimer.Tick += new System.EventHandler(this.followersUpdateTimer_Tick);
            // 
            // randomNotificationsTabPage
            // 
            this.randomNotificationsTabPage.Controls.Add(this.addRandomNotificationButton);
            this.randomNotificationsTabPage.Controls.Add(this.newRandomNotificationTextBox);
            this.randomNotificationsTabPage.Controls.Add(this.randomNotificationsListBox);
            this.randomNotificationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.randomNotificationsTabPage.Name = "randomNotificationsTabPage";
            this.randomNotificationsTabPage.Size = new System.Drawing.Size(533, 347);
            this.randomNotificationsTabPage.TabIndex = 2;
            this.randomNotificationsTabPage.Text = "Notification Commands";
            this.randomNotificationsTabPage.UseVisualStyleBackColor = true;
            // 
            // addRandomNotificationButton
            // 
            this.addRandomNotificationButton.Location = new System.Drawing.Point(297, 180);
            this.addRandomNotificationButton.Name = "addRandomNotificationButton";
            this.addRandomNotificationButton.Size = new System.Drawing.Size(75, 23);
            this.addRandomNotificationButton.TabIndex = 5;
            this.addRandomNotificationButton.Text = "Add";
            this.addRandomNotificationButton.UseVisualStyleBackColor = true;
            this.addRandomNotificationButton.Click += new System.EventHandler(this.addRandomNotificationButton_Click);
            // 
            // newRandomNotificationTextBox
            // 
            this.newRandomNotificationTextBox.Location = new System.Drawing.Point(4, 182);
            this.newRandomNotificationTextBox.Name = "newRandomNotificationTextBox";
            this.newRandomNotificationTextBox.Size = new System.Drawing.Size(287, 20);
            this.newRandomNotificationTextBox.TabIndex = 4;
            this.newRandomNotificationTextBox.Text = "this is a random notification";
            // 
            // randomNotificationsListBox
            // 
            this.randomNotificationsListBox.FormattingEnabled = true;
            this.randomNotificationsListBox.Location = new System.Drawing.Point(4, 3);
            this.randomNotificationsListBox.Name = "randomNotificationsListBox";
            this.randomNotificationsListBox.Size = new System.Drawing.Size(368, 173);
            this.randomNotificationsListBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 445);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.masterStatusStrip);
            this.Controls.Add(this.masterMenuStrip);
            this.MainMenuStrip = this.masterMenuStrip;
            this.Name = "MainForm";
            this.Text = "twitch-client";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.masterStatusStrip.ResumeLayout(false);
            this.masterStatusStrip.PerformLayout();
            this.masterMenuStrip.ResumeLayout(false);
            this.masterMenuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.broadcastingTabPage.ResumeLayout(false);
            this.broadcastingTabPage.PerformLayout();
            this.chatBotTabPage.ResumeLayout(false);
            this.chatBotSplitContainer.Panel1.ResumeLayout(false);
            this.chatBotSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chatBotSplitContainer)).EndInit();
            this.chatBotSplitContainer.ResumeLayout(false);
            this.chatBotSettingsTabPage.ResumeLayout(false);
            this.chatBotSettingsTabControl.ResumeLayout(false);
            this.chatBotCredsTabPage.ResumeLayout(false);
            this.echoCommandsTabPage.ResumeLayout(false);
            this.echoCommandsTabPage.PerformLayout();
            this.randomNotificationsTabPage.ResumeLayout(false);
            this.randomNotificationsTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip masterStatusStrip;
        private System.Windows.Forms.MenuStrip masterMenuStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage broadcastingTabPage;
        private UpdateBroadcastingInfoPanel updateBroadcastingInfoPanel;
        private BroadcastingInfoPanel broadcastingInfoPanel;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ToolStripStatusLabel mainStatsLabel;
        private WatchStreamPanel watchStreamPanel;
        private System.Windows.Forms.Timer followersUpdateTimer;
        private System.Windows.Forms.TextBox followersTextBox;
        private System.Windows.Forms.ToolStripMenuItem updatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleMainStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleFollowersToolStripMenuItem;
        private System.Windows.Forms.TabPage chatBotTabPage;
        private System.Windows.Forms.TabPage chatBotSettingsTabPage;
        private System.Windows.Forms.SplitContainer chatBotSplitContainer;
        private System.Windows.Forms.RichTextBox chatRichTextBox;
        private System.Windows.Forms.ListBox chatUsersListBox;
        private System.Windows.Forms.TabControl chatBotSettingsTabControl;
        private System.Windows.Forms.TabPage chatBotCredsTabPage;
        private Panels.ChatBot.ChatBotCredentialsPanel chatBotCredentialsPanel;
        private System.Windows.Forms.TabPage echoCommandsTabPage;
        private System.Windows.Forms.Button addEchoCommandButton;
        private System.Windows.Forms.TextBox newEchoCommandTextBox;
        private System.Windows.Forms.ListBox echoCommandsListBox;
        private System.Windows.Forms.TabPage randomNotificationsTabPage;
        private System.Windows.Forms.Button addRandomNotificationButton;
        private System.Windows.Forms.TextBox newRandomNotificationTextBox;
        private System.Windows.Forms.ListBox randomNotificationsListBox;
    }
}

