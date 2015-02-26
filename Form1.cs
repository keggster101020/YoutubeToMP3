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
            clearForm();
            download.Enabled = false;
            String websiteID = "http://www.dirpy.com/studio?url=" + youtubeURL.Text;
            websiteID.Trim();
            web.Navigate(websiteID);
            web.ScriptErrorsSuppressed = true;

            web.DocumentCompleted += (senders, eventArgs) =>
            {
                var eleTitle = (mshtml.IHTMLInputElement)web.Document.GetElementById("title").DomElement;
                if (!eleTitle.value.ToString().Contains("-"))
                    songTitleLabel.Text = eleTitle.value;
                else
                {

                    var eleArtist = (mshtml.IHTMLInputElement)web.Document.GetElementById("artist").DomElement;
                    if (eleArtist.value != null)
                        artistLabel.Text = eleArtist.value;
                    else
                    {
                        if (SongTitle.Text.ToString().Contains('-') || !String.IsNullOrEmpty(SongTitle.Text))
                        {
                            String[] titleArtist = eleTitle.value.ToString().Split('-');
                            songTitleLabel.Text = titleArtist[1];
                            artistLabel.Text = titleArtist[0];
                        }
                        else
                        {
                            artistLabel.Text = "Unknown Artist";
                        }
                    }
                }
            };


            downloadSong(websiteID);
            download.Enabled = true;
        }

        private void downloadSong(String ID)
        {
            download.Enabled = false;

            //var holder = web.Document.GetElementsByTagName("input");
            WebBrowser webb = new WebBrowser();
            webb.Navigate(ID);
            webb.ScriptErrorsSuppressed = true;
      
            if (webb.ReadyState != WebBrowserReadyState.Complete) return; //check to make sure that there are elements
            foreach (HtmlElement item in web.Document.GetElementsByTagName("input"))
            {
                if (!item.Equals(null))
                {
                    if (item.GetAttribute("value").Equals("Record Audio"))
                    {
                        MetroMessageBox.Show(this, "" + item.GetAttribute("value"));
                        web.Document.InvokeScript("download('audio')");
                    }
                }
            }
        }

        public void clearForm()
        {
            songTitleLabel.Text = "";
            artistLabel.Text = "";
            web = new WebBrowser();
           
        }

        /*void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Console.WriteLine("Success");
        }*/
    }
}
