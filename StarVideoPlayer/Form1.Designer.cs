﻿namespace StarVideoPlayer
{
    partial class Form1
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.favoritesButton = new System.Windows.Forms.Button();
            this.recentlyAddedButton = new System.Windows.Forms.Button();
            this.recentlyPlayedButton = new System.Windows.Forms.Button();
            this.recentlyViewedButton = new System.Windows.Forms.Button();
            this.nowPlayingButton = new System.Windows.Forms.Button();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.volumeControl = new System.Windows.Forms.TrackBar();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.headPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.filesDialogButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.rewindButton = new System.Windows.Forms.Button();
            this.fastForwardButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).BeginInit();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(74)))));
            this.leftPanel.Controls.Add(this.logoPictureBox);
            this.leftPanel.Controls.Add(this.favoritesButton);
            this.leftPanel.Controls.Add(this.recentlyAddedButton);
            this.leftPanel.Controls.Add(this.recentlyPlayedButton);
            this.leftPanel.Controls.Add(this.recentlyViewedButton);
            this.leftPanel.Controls.Add(this.nowPlayingButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(189, 729);
            this.leftPanel.TabIndex = 0;
            // 
            // favoritesButton
            // 
            this.favoritesButton.FlatAppearance.BorderSize = 0;
            this.favoritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoritesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.favoritesButton.ForeColor = System.Drawing.Color.White;
            this.favoritesButton.Location = new System.Drawing.Point(3, 393);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(189, 63);
            this.favoritesButton.TabIndex = 4;
            this.favoritesButton.Text = "     Favorites";
            this.favoritesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favoritesButton.UseVisualStyleBackColor = true;
            // 
            // recentlyAddedButton
            // 
            this.recentlyAddedButton.FlatAppearance.BorderSize = 0;
            this.recentlyAddedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recentlyAddedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recentlyAddedButton.ForeColor = System.Drawing.Color.White;
            this.recentlyAddedButton.Location = new System.Drawing.Point(0, 324);
            this.recentlyAddedButton.Name = "recentlyAddedButton";
            this.recentlyAddedButton.Size = new System.Drawing.Size(189, 63);
            this.recentlyAddedButton.TabIndex = 3;
            this.recentlyAddedButton.Text = "     Recently Added";
            this.recentlyAddedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recentlyAddedButton.UseVisualStyleBackColor = true;
            // 
            // recentlyPlayedButton
            // 
            this.recentlyPlayedButton.FlatAppearance.BorderSize = 0;
            this.recentlyPlayedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recentlyPlayedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recentlyPlayedButton.ForeColor = System.Drawing.Color.White;
            this.recentlyPlayedButton.Location = new System.Drawing.Point(0, 255);
            this.recentlyPlayedButton.Name = "recentlyPlayedButton";
            this.recentlyPlayedButton.Size = new System.Drawing.Size(189, 63);
            this.recentlyPlayedButton.TabIndex = 2;
            this.recentlyPlayedButton.Text = "     Recently Played";
            this.recentlyPlayedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recentlyPlayedButton.UseVisualStyleBackColor = true;
            // 
            // recentlyViewedButton
            // 
            this.recentlyViewedButton.FlatAppearance.BorderSize = 0;
            this.recentlyViewedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recentlyViewedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recentlyViewedButton.ForeColor = System.Drawing.Color.White;
            this.recentlyViewedButton.Location = new System.Drawing.Point(3, 186);
            this.recentlyViewedButton.Name = "recentlyViewedButton";
            this.recentlyViewedButton.Size = new System.Drawing.Size(189, 63);
            this.recentlyViewedButton.TabIndex = 1;
            this.recentlyViewedButton.Text = "     Recently Viewed";
            this.recentlyViewedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recentlyViewedButton.UseVisualStyleBackColor = true;
            // 
            // nowPlayingButton
            // 
            this.nowPlayingButton.FlatAppearance.BorderSize = 0;
            this.nowPlayingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nowPlayingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowPlayingButton.ForeColor = System.Drawing.Color.White;
            this.nowPlayingButton.Location = new System.Drawing.Point(0, 117);
            this.nowPlayingButton.Name = "nowPlayingButton";
            this.nowPlayingButton.Size = new System.Drawing.Size(189, 63);
            this.nowPlayingButton.TabIndex = 0;
            this.nowPlayingButton.Text = "     Now Playing";
            this.nowPlayingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nowPlayingButton.UseVisualStyleBackColor = true;
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.controlsPanel.Controls.Add(this.filesDialogButton);
            this.controlsPanel.Controls.Add(this.volumeControl);
            this.controlsPanel.Controls.Add(this.stopButton);
            this.controlsPanel.Controls.Add(this.rewindButton);
            this.controlsPanel.Controls.Add(this.fastForwardButton);
            this.controlsPanel.Controls.Add(this.playButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsPanel.Location = new System.Drawing.Point(189, 650);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(819, 79);
            this.controlsPanel.TabIndex = 1;
            // 
            // volumeControl
            // 
            this.volumeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeControl.LargeChange = 1000;
            this.volumeControl.Location = new System.Drawing.Point(636, 22);
            this.volumeControl.Maximum = 0;
            this.volumeControl.Minimum = -3000;
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Size = new System.Drawing.Size(137, 45);
            this.volumeControl.SmallChange = 500;
            this.volumeControl.TabIndex = 6;
            this.volumeControl.Value = -1500;
            this.volumeControl.Scroll += new System.EventHandler(this.VolumeControl_Scroll);
            // 
            // playerPanel
            // 
            this.playerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(47)))));
            this.playerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playerPanel.Location = new System.Drawing.Point(189, 40);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(819, 610);
            this.playerPanel.TabIndex = 2;
            this.playerPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayerPanel_MouseDoubleClick);
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.headPanel.Controls.Add(this.minimizeButton);
            this.headPanel.Controls.Add(this.maximizeButton);
            this.headPanel.Controls.Add(this.exitButton);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(189, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(819, 40);
            this.headPanel.TabIndex = 0;
            this.headPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseDown);
            this.headPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseMove);
            this.headPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackgroundImage = global::StarVideoPlayer.Properties.Resources._003_arrows_pointing_to_center;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.minimizeButton.Location = new System.Drawing.Point(672, 4);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.minimizeButton.Size = new System.Drawing.Size(30, 33);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "\r\n";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackgroundImage = global::StarVideoPlayer.Properties.Resources._002_expand_view;
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maximizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.maximizeButton.Location = new System.Drawing.Point(724, 4);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.maximizeButton.Size = new System.Drawing.Size(30, 33);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.Text = "\r\n";
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackgroundImage = global::StarVideoPlayer.Properties.Resources._001_delete1;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.exitButton.Location = new System.Drawing.Point(775, 3);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.exitButton.Size = new System.Drawing.Size(30, 33);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "\r\n";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // filesDialogButton
            // 
            this.filesDialogButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.filesDialogButton.BackgroundImage = global::StarVideoPlayer.Properties.Resources.folder;
            this.filesDialogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filesDialogButton.FlatAppearance.BorderSize = 0;
            this.filesDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filesDialogButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.filesDialogButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.filesDialogButton.Location = new System.Drawing.Point(28, 22);
            this.filesDialogButton.Name = "filesDialogButton";
            this.filesDialogButton.Size = new System.Drawing.Size(46, 45);
            this.filesDialogButton.TabIndex = 7;
            this.filesDialogButton.Text = "\r\n";
            this.filesDialogButton.UseVisualStyleBackColor = true;
            this.filesDialogButton.Click += new System.EventHandler(this.FilesDialogButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stopButton.BackgroundImage = global::StarVideoPlayer.Properties.Resources._003_stop_21;
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stopButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.stopButton.Location = new System.Drawing.Point(257, 22);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(46, 45);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "\r\n";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // rewindButton
            // 
            this.rewindButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rewindButton.BackgroundImage = global::StarVideoPlayer.Properties.Resources._001_rewind;
            this.rewindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rewindButton.FlatAppearance.BorderSize = 0;
            this.rewindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rewindButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rewindButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.rewindButton.Location = new System.Drawing.Point(321, 22);
            this.rewindButton.Name = "rewindButton";
            this.rewindButton.Size = new System.Drawing.Size(46, 45);
            this.rewindButton.TabIndex = 4;
            this.rewindButton.Text = "\r\n";
            this.rewindButton.UseVisualStyleBackColor = true;
            this.rewindButton.Click += new System.EventHandler(this.RewindButton_Click);
            // 
            // fastForwardButton
            // 
            this.fastForwardButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fastForwardButton.BackgroundImage = global::StarVideoPlayer.Properties.Resources._001_rewindRight;
            this.fastForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fastForwardButton.FlatAppearance.BorderSize = 0;
            this.fastForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastForwardButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastForwardButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fastForwardButton.Location = new System.Drawing.Point(454, 22);
            this.fastForwardButton.Name = "fastForwardButton";
            this.fastForwardButton.Size = new System.Drawing.Size(46, 45);
            this.fastForwardButton.TabIndex = 3;
            this.fastForwardButton.Text = "\r\n";
            this.fastForwardButton.UseVisualStyleBackColor = true;
            this.fastForwardButton.Click += new System.EventHandler(this.FastForwardButton_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playButton.BackgroundImage = global::StarVideoPlayer.Properties.Resources._004_play_button_1;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.playButton.Location = new System.Drawing.Point(386, 22);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(46, 45);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "\r\n";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImage = global::StarVideoPlayer.Properties.Resources.video_player__1_;
            this.logoPictureBox.Location = new System.Drawing.Point(53, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(64, 64);
            this.logoPictureBox.TabIndex = 5;
            this.logoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).EndInit();
            this.headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button rewindButton;
        private System.Windows.Forms.Button fastForwardButton;
        private System.Windows.Forms.Button favoritesButton;
        private System.Windows.Forms.Button recentlyAddedButton;
        private System.Windows.Forms.Button recentlyPlayedButton;
        private System.Windows.Forms.Button recentlyViewedButton;
        private System.Windows.Forms.Button nowPlayingButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TrackBar volumeControl;
        private System.Windows.Forms.Button filesDialogButton;
    }
}

