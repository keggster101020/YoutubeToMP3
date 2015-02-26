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


            //downloadSong();
            download.Enabled = true;
        }

        private void downloadSong()
        {
            download.Enabled = false;
            try
            {
                foreach(HtmlElement item in web.Document.GetElementsByTagName("input")){
                    if (item.GetAttribute("value").Equals("Record Audio"))
                        item.InvokeMember("click");
                }
                
            }
            catch(Exception excp){
                MessageBox.Show(excp.ToString());
            }
        }


        /*void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Console.WriteLine("Success");
        }*/
    }
}
