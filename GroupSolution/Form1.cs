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
using System.Net;
using System.IO;
using System.Timers;


namespace GroupSolution
{
    public partial class btnMaster : Form
    {
        public btnMaster()
        {
            InitializeComponent();
        }

        private void Group_Images_Load(object sender, EventArgs e)
        {
            
        }

        public static bool IsLogin = false;
        public static bool IsBackFromLogin = false;
        bool group = false;
        public static string GroupId = "";
        public static string GroupName = "";
        public string FileId = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            btnImages.Hide();
            if (IsLogin != true)
            {
                btnLogin.Text = "Login";
                Welcome frm = new Welcome();
                frm.ShowDialog();
                if (IsLogin == true)
                {
                    lblAccountName.Text = FBclass.GetUserName(Settings1.Default.AccessToken);
                    string imgURL = string.Format("http://graph.facebook.com/{0}/picture", FBclass.GetUserID(Settings1.Default.AccessToken));
                    imgAccount.ImageLocation = imgURL;
                    btnLogin.Text = "Logged In";
                }
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (IsBackFromLogin == true)
            {
                IsBackFromLogin = false;
            }

        }

        private void lstName_Click(object sender, EventArgs e)
        {
            if (lstName.SelectedItem != null)
            { 
                lblID.Text = "You Selected : " + ((ListItem)this.lstName.SelectedItem).Text;
                GroupName = ((ListItem)this.lstName.SelectedItem).Text;
                GroupId = ((ListItem)this.lstName.SelectedItem).Id;
                Settings1.Default.GroupName = GroupName;
                Settings1.Default.GroupId = GroupId;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsLogin == false)
            {
                MessageBox.Show("Login First !!");
            }
            else
            {
                if (group == false)
                {
                    lstName.Items.Clear();
                    btnMast.Text = "Get Files";
                    btnImages.Show();
                    group = true;
                    //start = false;
                    FacebookClient fb = new FacebookClient(Settings1.Default.AccessToken);
                    dynamic list = fb.Get("me/groups");
                    int Count = list.data.Count;
                    for (int i = 0; i < Count; i++)
                    {
                        progressGroup.Maximum = Count;
                        progressGroup.Value = lstName.Items.Count;
                        lstName.Items.Add(new ListItem(list.data[i].id, list.data[i].name));
                        lstName.DoubleClick += new EventHandler(lstName_Click);
                    }
                }
                else
                {
                    if (GroupId.Length == 0)
                    {
                        MessageBox.Show("Select Group First");
                    }
                    else
                    {
                        Group_Files frm = new Group_Files();
                        frm.ShowDialog();
                        GroupId = "";
                        GroupName = "";
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsLogin != true)
            {
                Login frm = new Login();
                frm.ShowDialog();
                if (IsLogin == true)
                {
                    lblAccountName.Text = FBclass.GetUserName(Settings1.Default.AccessToken);
                    string imgURL = string.Format("http://graph.facebook.com/{0}/picture", FBclass.GetUserID(Settings1.Default.AccessToken));
                    imgAccount.ImageLocation = imgURL;
                    btnLogin.Text = "Logged In";
                }
            }
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            if (GroupId.Length == 0)
            {
                MessageBox.Show("Select Group First");
            }
            else
            {
                Group_Images frm = new Group_Images();
                frm.ShowDialog();
                GroupId = "";
                GroupName = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update frm = new update();
            frm.ShowDialog();
        }
    }
}