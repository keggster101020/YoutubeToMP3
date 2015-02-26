using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MetroFramework;
using MetroFramework.Forms;

namespace YoutubeToMP3
{
    public partial class YoutubeMP3 : MetroFramework.Forms.MetroForm
    {
        public YoutubeMP3()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void download_Click(object sender, EventArgs e)
        {
            String websiteID = "http://www.dirpy.com/studio?url=" + youtubeURL.Text;
            websiteID.Trim();
            web.Navigate(websiteID);
            web.ScriptErrorsSuppressed = true;

            web.DocumentCompleted += (senders, eventArgs) =>
            {
                var eleTitle = (mshtml.IHTMLInputElement)web.Document.GetElementById("title").DomElement;
                songTitleLabel.Text = "Title: " + eleTitle.value;

                var eleArtist = (mshtml.IHTMLInputElement)web.Document.GetElementById("artist").DomElement;
                if (eleArtist.value != null) artistLabel.Text = "Artist: " + eleArtist.value;
                else
                {
                    if (songTitleLabel.Text.ToString().Contains('-') || !String.IsNullOrEmpty(songTitleLabel.Text))
                    {
                        artistLabel.Text = "Artist: " + songTitleLabel.Text.ToString().Split('-')[0];
                    }
                    else
                    {
                        artistLabel.Text = "Unknown Artist";
                    }
                }
            };



            //downloadSong();
        }

        private void downloadSong()
        {
            try
            {

                
            }
            catch(Exception excp){
                MessageBox.Show(excp.ToString());
            }
        }


        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Console.WriteLine("We have Bing");
        }
    }
}
