using System;
using System.IO;
using System.Web;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Timers;
using System.Threading;

namespace GroupSolution
{
    public partial class Group_Images : Form
    {

        private Queue<string> _downloadUrls = new Queue<string>();
        string dir = @"d:\GroupSolutions\" + Settings1.Default.GroupName + "\\images\\";
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        WebClient webClient = new WebClient();
        bool stop = false;

        public Group_Images()
        {
            InitializeComponent();
            this.FormClosing += Group_Images_FormClosing;
        }
        
        private void Group_Images_Load(object sender, EventArgs e)
        {
            t.Interval = 4000000;  // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        private void Group_Images_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop = true;
            webClient.CancelAsync();
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)
            {
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Are you sure?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }


        void timer_Tick(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            FacebookClient fb1 = new FacebookClient(Settings1.Default.AccessToken);
            string query = Settings1.Default.GroupId + "/feed";
            while (stop == false)
            {
                Application.DoEvents();
                dynamic feedList = fb1.Get(query);

                foreach (dynamic each in feedList.data)
                {
                    if (stop == true) break;
                    if (each.type == "photo")
	                {
		                    int Count = feedList.data.Count;
                            Application.DoEvents();
                            if (each.type.ToString() == "photo" )
                            {
                                if (each.properties != null)
                                {

                                }
                                else
                                {
                                    string link = HttpUtility.UrlDecode(each.link);
                                    string link1 = link.Substring(link.IndexOf("fbid=") + 5);
                                    string link2 = link1.Substring(0, link1.IndexOf("&"));
                                    dynamic image = fb1.Get(link2);
                                    string imgURL = image.source;
                                    string id = each.id + ".jpg";
                                    if (!File.Exists(@"d:\GroupSolutions\" + Settings1.Default.GroupName + "\\images\\"+id))
                                    {
                                        string lines = "ID : " + each.id + "\r\n" + "Name : " + id + "\r\n" + "Link : " + link;
                                        listBox1.Items.Add(new ListItem(link, id));
                                        Uri download_link = new Uri(imgURL);
                                        pbDownload.ImageLocation = imgURL;
                                        string url = download_link.ToString();
                                        _downloadUrls.Enqueue(url);
                                        lblName.Text = "Intializing ..";
                                        lblName.Text += id;
                                        if (!Directory.Exists(dir))
                                        {
                                            Directory.CreateDirectory(dir);
                                        }
                                        string filename = id + ".txt";
                                        TextWriter file = new StreamWriter(dir + filename);
                                        file.WriteLine(Settings1.Default.GroupName);
                                        if (each.message != null)
                                        {
                                            file.WriteLine(each.message);
                                        }
                                        if (image.comments != null)
                                        {
                                            int count = image.comments.data.Count;
                                                for (int i = 0; i < count; i++)
                                                {
                                                    dynamic comment = image.comments.data[i];
                                                    file.WriteLine(comment.from.name + " : " + comment.message);
                                                }
                                        }
                                          
                                        file.Close();
                                        webClient.DownloadFileAsync(new Uri(url), dir + id);
                                        webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
                                        while (webClient.IsBusy)
                                        {
                                            System.Threading.Thread.Sleep(0);
                                            Application.DoEvents();
                                        }
                                    }
                                }
                            }
                        }
                            

                        if (string.IsNullOrEmpty(feedList.paging.next))
                        {
                            break;
                        }
                        else
                        {
                             Application.DoEvents();
                            query = feedList.paging.next;
                        }
                    }

                    Settings1.Default.GroupId = "";
	        }
        }


        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }
        
        void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            int bytesin = int.Parse(e.BytesReceived.ToString());
            int totalbytes = int.Parse(e.TotalBytesToReceive.ToString());
            int kb1 = bytesin / 1024;
            int kb2 = totalbytes / 1024;
            lblName.Text = " Downloading : " + kb1 + "Kb / " + kb2 + "Kb (" + e.ProgressPercentage.ToString() + "%)";
            //progressGroup.Value = e.ProgressPercentage;
        } 
    }
}
