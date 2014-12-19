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
    public partial class Group_Files : Form
    {


        bool stop = false;
        private Queue<string> _downloadUrls = new Queue<string>();
        string dir = @"d:\GroupSolutions\" + Settings1.Default.GroupName + "\\";
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        WebClient webClient = new WebClient();


        public Group_Files()
        {
            InitializeComponent();
            this.FormClosing += Group_Files_FormClosing;
        }

        private void Group_Files_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Group_Files_Load(object sender, EventArgs e)
        {
            t.Interval = 4000000;  // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private  void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
             int bytesin = int.Parse(e.BytesReceived.ToString());
             int totalbytes = int.Parse(e.TotalBytesToReceive.ToString());
             int kb1 = bytesin / 1024;
             int kb2 = Math.Abs(totalbytes) / 1024;
             lblDownload.Text = " Downloading : " + kb1 + "Kb / " + kb2 + "Kb (" + e.ProgressPercentage.ToString() + "%)";
        }
        
        

        private void btnDownload_Click(object sender, EventArgs e)
        {
            FacebookClient fb1 = new FacebookClient(Settings1.Default.AccessToken);
            string query = Settings1.Default.GroupId + "/files";
            lstFiles.Items.Clear();
            lstDownload.Items.Clear();
            stop = false;
            while (stop == false)
            {
                dynamic feedList = null;
                try
                {
                    feedList = fb1.Get(query);
                }
                catch (FacebookOAuthException)
                {
                    Login frm = new Login();
                    frm.ShowDialog();
                }
                feedList = fb1.Get(query);
                foreach (dynamic each in feedList.data)
                {
                    if (stop == true) break;
                    int Count = feedList.data.Count;
                    Application.DoEvents();
                    string link = HttpUtility.UrlDecode(each.download_link);
                    string id = each.id;
                    int len = id.Length + 11;
                    string link1 = link.Substring(link.IndexOf("download") + len);
                    string lines = "ID : " + each.id + "\r\n" + "Name : " + link1 + "\r\n" + "Link : " + link;
                    string FileName = each.download_link.Substring(each.download_link.IndexOf("download/") + 25);
                    string name = HttpUtility.UrlDecode(FileName);
                    if (id != null)
                    {
                        lstDownload.Items.Add(new ListItem(link, name));
                        if (!File.Exists(@"d:\GroupSolutions\" + Settings1.Default.GroupName + "\\"+name))
                        {
                            lstFiles.Items.Add(new ListItem(link, name));
                            string url = each.download_link.ToString();
                            _downloadUrls.Enqueue(url);
                            Uri download_link = new Uri(each.download_link);
                            lblDownload.Text = "Intializing ..";
                            lblDownload.Text += name;
                            if (!Directory.Exists(dir))
                            {
                                Directory.CreateDirectory(dir);
                            }
                            string filename = name + ".txt";
                            TextWriter file = new StreamWriter(dir + filename);
                            file.WriteLine(Settings1.Default.GroupName);
                            if (each.message != null)
                            {
                                file.WriteLine(each.message);
                            }
                            if (each.comments != null)
                            {
                                int count = each.comments.data.Count;
                                for (int i = 0; i < count; i++)
                                {
                                    dynamic comment = each.comments.data[i];
                                    file.WriteLine(comment.from.name + " : " + comment.message);
                                }
                            }

                            file.Close();
                            webClient.DownloadFileAsync(download_link, dir + name);
                            webClient.DownloadProgressChanged += client_DownloadProgressChanged;
                            while (webClient.IsBusy)
                            {
                                System.Threading.Thread.Sleep(0);
                                Application.DoEvents(); 
                            }
                        }
                    }
                }

                if (string.IsNullOrEmpty(feedList.paging.next))
                {
                    lblDownload.Text = " Complete !";
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

        private void button1_Click(object sender, EventArgs e)
        {
            stop = true;
            webClient.CancelAsync();
        }
    }
}
