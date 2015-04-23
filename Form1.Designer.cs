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
            this.songTitleLabel = new MetroFramework.Controls.MetroTextBox();
            this.SongTitle = new MetroFramework.Controls.MetroLabel();
            this._artistLabel = new MetroFramework.Controls.MetroLabel();
            this.youtubeURL = new MetroFramework.Controls.MetroTextBox();
            this.download = new MetroFramework.Controls.MetroButton();
            this.artistLabel = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.Lines = new string[] {
        "metroTextBox1"};
            this.songTitleLabel.Location = new System.Drawing.Point(128, 139);
            this.songTitleLabel.MaxLength = 32767;
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.PasswordChar = '\0';
            this.songTitleLabel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.songTitleLabel.SelectedText = "";
            this.songTitleLabel.Size = new System.Drawing.Size(219, 23);
            this.songTitleLabel.TabIndex = 5;
            this.songTitleLabel.Text = "metroTextBox1";
            this.songTitleLabel.UseSelectable = true;
            // 
            // SongTitle
            // 
            this.SongTitle.AutoSize = true;
            this.SongTitle.Location = new System.Drawing.Point(55, 139);
            this.SongTitle.Name = "SongTitle";
            this.SongTitle.Size = new System.Drawing.Size(67, 19);
            this.SongTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.SongTitle.TabIndex = 3;
            this.SongTitle.Text = "Song Title";
            this.SongTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // _artistLabel
            // 
            this._artistLabel.AutoSize = true;
            this._artistLabel.Location = new System.Drawing.Point(55, 172);
            this._artistLabel.Name = "_artistLabel";
            this._artistLabel.Size = new System.Drawing.Size(40, 19);
            this._artistLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this._artistLabel.TabIndex = 3;
            this._artistLabel.Text = "Artist";
            this._artistLabel.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.Style = MetroFramework.MetroColorStyle.Blue;
            this.download.TabIndex = 1;
            this.download.Text = "Download";
            this.download.Theme = MetroFramework.MetroThemeStyle.Light;
            this.download.UseSelectable = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // artistLabel
            // 
            this.artistLabel.Lines = new string[] {
        "metroTextBox1"};
            this.artistLabel.Location = new System.Drawing.Point(128, 168);
            this.artistLabel.MaxLength = 32767;
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.PasswordChar = '\0';
            this.artistLabel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.artistLabel.SelectedText = "";
            this.artistLabel.Size = new System.Drawing.Size(219, 23);
            this.artistLabel.TabIndex = 5;
            this.artistLabel.Text = "metroTextBox1";
            this.artistLabel.UseSelectable = true;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(55, 221);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(378, 19);
            this.metroProgressBar1.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(439, 221);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // YoutubeMP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 383);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.songTitleLabel);
            this.Controls.Add(this._artistLabel);
            this.Controls.Add(this.SongTitle);
            this.Controls.Add(this.download);
            this.Controls.Add(this.youtubeURL);
            this.Name = "YoutubeMP3";
            this.Text = "Youtube-MP3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox songTitleLabel;
        private MetroFramework.Controls.MetroLabel SongTitle;
        private MetroFramework.Controls.MetroLabel _artistLabel;
        private MetroFramework.Controls.MetroTextBox youtubeURL;
        private MetroFramework.Controls.MetroButton download;
        private MetroFramework.Controls.MetroTextBox artistLabel;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

