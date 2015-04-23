using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
using YoutubeExtractor;

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
            /*
            web.DocumentCompleted += (senders, eventArgs) =>
            {
                var eleTitle = (mshtml.IHTMLInputElement)web.Document.GetElementById("title").DomElement;
                if (!eleTitle.value.ToString().Contains("-"))
                    songTitleLabel.Text = eleTitle.value;
                else
                {

                    var eleArtist = (mshtml.IHTMLInputElement)web.Document.GetElementById("artist").DomElement;
                    if (eleArtist.value != null) //checking the arist to see if there was anything there
                        artistLabel.Text = eleArtist.value;
                    else
                    {
                        //there was nothing in the artist aread, check if it got placed in the title
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
            while (web.IsBusy) { }*/

            //web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(downloadSong);
            //downloadSong();
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(youtubeURL.Text);
            /*
 * We want the first extractable video with the highest audio quality.
 */
            //try
          //  {
                VideoInfo video = videoInfos
                    .Where(info => info.CanExtractAudio)
                    .OrderByDescending(info => info.AudioBitrate)
                    .First();
                /*
                 * If the video has a decrypted signature, decipher it
                 */
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                /*
                 * Create the audio downloader.
                 * The first argument is the video where the audio should be extracted from.
                 * The second argument is the path to save the audio file.
                 */
                var audioDownloader = new AudioDownloader(video, Path.Combine("C:\\Users\\Keegan\\Desktop", video.Title + video.AudioExtension));

                // Register the progress events. We treat the download progress as 85% of the progress and the extraction progress only as 15% of the progress,
                // because the download will take much longer than the audio extraction.
                audioDownloader.DownloadProgressChanged += (sendera, args) => metroProgressBar1.Value=(int) (args.ProgressPercentage * 0.85);
                audioDownloader.AudioExtractionProgressChanged += (sendera, args) => metroProgressBar1.Value= (int)(85 + args.ProgressPercentage * 0.15);
                
                
                //metroProgressBar1.Invoke(new MethodInvoker(delegate{ (args.ProgressPercentage)}));
                /*
                 * Execute the audio downloader.
                 * For GUI applications note, that this method runs synchronously.
                 */
                 
                audioDownloader.Execute();
                //new Task(() => { audioDownloader.Execute(); }).Start();
                

            //}
            //catch (Exception eio) { MessageBox.Show("ERROR"); }
            download.Enabled = true;
        }

        //private void downloadSong()//Object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //    download.Enabled = false;

        //    //var holder = web.Document.GetElementsByTagName("input");

        //    //MessageBox.Show("READY");
        //    //if (web.ReadyState != WebBrowserReadyState.Complete) return; //check to make sure that there are elements
        //    MetroMessageBox.Show(this, "about to download");
        //    web.Document.InvokeScript("epomDownload");
        //    MetroMessageBox.Show(this, "done");
        //    while (web.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
        //    foreach (HtmlElement item in web.Document.GetElementsByTagName("input"))
        //    {
        //        if (!item.Equals(null))
        //        {
        //            Console.WriteLine(item.GetAttribute("value").ToString());
        //            if (item.GetAttribute("value").Equals("Record Audio", StringComparison.InvariantCultureIgnoreCase))
        //            {
        //                MessageBox.Show("inside");
        //                MetroMessageBox.Show(this, "" + item.GetAttribute("value"));
        //                // web.Document.InvokeScript("download", new Object [] {
        //                //                                        "audio"});
        //                // web.Document.InvokeScript("epomDownload");

        //            }
        //        }
        //    }
        //    //web.Document.InvokeScript("download", new String []{
        //    //                                      "audio"});
        //}

        public void clearForm()
        {
            artistLabel.Text = "";
            songTitleLabel.Text = "";
            //web = new WebBrowser();
            //web.Show();
            //web.Visible = true;

        }

        /*void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Console.WriteLine("Success");
        }*/
    }
}
