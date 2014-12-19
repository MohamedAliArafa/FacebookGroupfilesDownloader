using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupSolution
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        public static bool IsLogin = false;
        public static bool IsBackFromLogin = false;

        private void Welcome_Load(object sender, EventArgs e)
        {
            textBox1.Text = " Welcome To Group Solution The First And Only Facebook Group Files Downloader On Internet ." + Environment.NewLine + "We Promise You That All Your Data Are Highly Secured By The Facebook Api Standers " + Environment.NewLine + "And The Programe Will not Save By Any Means Your Actions , Hope You Enjoy The Programe " + Environment.NewLine + "Developed By Mohamed Arafa :: " + @"www.facebook.com/arafaway";
            Form frm = new Form();
            IsLogin = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsLogin != true)
            {
                Login frm = new Login();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
