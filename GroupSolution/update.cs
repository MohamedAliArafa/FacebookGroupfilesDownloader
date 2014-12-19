using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Web;
using System.IO;

namespace GroupSolution
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void update_FormClosing(object sender, FormClosingEventArgs e)
        {
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


        string dir = @"d:\GroupSolutions\" + Settings1.Default.GroupName + "\\images\\";

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FacebookClient fb1 = new FacebookClient(Settings1.Default.AccessToken);
            string query = Settings1.Default.GroupId + "/feed";
            while (true)
            {
                Application.DoEvents();
                dynamic feedList = fb1.Get(query);
                foreach (dynamic each in feedList.data)
                {
                    lblCount.Text = listBox1.Items.Count.ToString() + " Updated";
                    if (each.type == "photo")
                    {
                        int Count = feedList.data.Count;
                        Application.DoEvents();
                        if (each.type.ToString() == "photo")
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
                                if (File.Exists(@"d:\GroupSolutions\" + Settings1.Default.GroupName + "\\images\\" + id))
                                {
                                    string lines = "ID : " + each.id + "\r\n" + "Name : " + id + "\r\n" + "Link : " + link;
                                    listBox1.Items.Add(new ListItem(link, id));
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


    }
}
