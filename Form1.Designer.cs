namespace YoutubeToMP3
{
    partial class YoutubeMP3
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.youtubeURL = new MetroFramework.Controls.MetroTextBox();
            this.download = new MetroFramework.Controls.MetroButton();
            this.songTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.artistLabel = new MetroFramework.Controls.MetroLabel();
            this.web = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // youtubeURL
            // 
            this.youtubeURL.Lines = new string[] {
        "Input Youtube URL"};
            this.youtubeURL.Location = new System.Drawing.Point(55, 90);
            this.youtubeURL.MaxLength = 32767;
            this.youtubeURL.Name = "youtubeURL";
            this.youtubeURL.PasswordChar = '\0';
            this.youtubeURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.youtubeURL.SelectedText = "";
            this.youtubeURL.Size = new System.Drawing.Size(297, 23);
            this.youtubeURL.Style = MetroFramework.MetroColorStyle.Blue;
            this.youtubeURL.TabIndex = 0;
            this.youtubeURL.Text = "Input Youtube URL";
            this.youtubeURL.Theme = MetroFramework.MetroThemeStyle.Light;
            this.youtubeURL.UseSelectable = true;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(358, 90);
            this.download.Name = "download";
            this.download.Style = MetroFramework.MetroColorStyle.Blue;
            this.download.TabIndex = 1;
            this.download.Text = "Download";
            this.download.Theme = MetroFramework.MetroThemeStyle.Light;
            this.download.UseSelectable = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.AutoSize = true;
            this.songTitleLabel.Location = new System.Drawing.Point(55, 139);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(67, 19);
            this.songTitleLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.songTitleLabel.TabIndex = 3;
            this.songTitleLabel.Text = "Song Title";
            this.songTitleLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(55, 158);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(40, 19);
            this.artistLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.artistLabel.TabIndex = 3;
            this.artistLabel.Text = "Artist";
            this.artistLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(438, 12);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(480, 348);
            this.web.TabIndex = 4;
            // 
            // YoutubeMP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 383);
            this.Controls.Add(this.web);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.songTitleLabel);
            this.Controls.Add(this.download);
            this.Controls.Add(this.youtubeURL);
            this.Name = "YoutubeMP3";
            this.Text = "Youtube-MP3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private MetroFramework.Controls.MetroTextBox youtubeURL;
        private MetroFramework.Controls.MetroButton download;
        private MetroFramework.Controls.MetroLabel songTitleLabel;
        private MetroFramework.Controls.MetroLabel artistLabel;
        private System.Windows.Forms.WebBrowser web;
    }
}

