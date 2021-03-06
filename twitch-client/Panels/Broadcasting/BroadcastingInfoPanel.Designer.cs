﻿namespace TwitchClient.Panels.Broadcasting
{
    partial class BroadcastingInfoPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.avgFpsLabel = new System.Windows.Forms.Label();
            this.srcVidQualLabel = new System.Windows.Forms.Label();
            this.labelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(3, 3);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(47, 13);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.Text = "Game: ?";
            this.labelToolTip.SetToolTip(this.gameLabel, "The current game you are broadcasting.");
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title: ?";
            this.labelToolTip.SetToolTip(this.titleLabel, "The current title of your broadcast.");
            // 
            // avgFpsLabel
            // 
            this.avgFpsLabel.AutoSize = true;
            this.avgFpsLabel.Location = new System.Drawing.Point(3, 29);
            this.avgFpsLabel.Name = "avgFpsLabel";
            this.avgFpsLabel.Size = new System.Drawing.Size(82, 13);
            this.avgFpsLabel.TabIndex = 2;
            this.avgFpsLabel.Text = "Average FPS: ?";
            this.labelToolTip.SetToolTip(this.avgFpsLabel, "The average frames per second twitch is receiving from you (over the last sample)" +
        ".");
            // 
            // srcVidQualLabel
            // 
            this.srcVidQualLabel.AutoSize = true;
            this.srcVidQualLabel.Location = new System.Drawing.Point(3, 42);
            this.srcVidQualLabel.Name = "srcVidQualLabel";
            this.srcVidQualLabel.Size = new System.Drawing.Size(118, 13);
            this.srcVidQualLabel.TabIndex = 3;
            this.srcVidQualLabel.Text = "Source Video Quality: ?";
            this.labelToolTip.SetToolTip(this.srcVidQualLabel, "The height of your broadcast\'s video.");
            // 
            // labelToolTip
            // 
            this.labelToolTip.IsBalloon = true;
            this.labelToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.labelToolTip.ToolTipTitle = "Broadcasting Info";
            // 
            // BroadcastingInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.srcVidQualLabel);
            this.Controls.Add(this.avgFpsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.gameLabel);
            this.Name = "BroadcastingInfoPanel";
            this.Size = new System.Drawing.Size(300, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label avgFpsLabel;
        private System.Windows.Forms.Label srcVidQualLabel;
        private System.Windows.Forms.ToolTip labelToolTip;
    }
}
