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

namespace GroupSolution
{
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void webFacebook_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
                btnMaster.IsLogin = false;
                btnMaster.IsBackFromLogin = false;
                this.Close();
        }

        private void Logout_Load(object sender, EventArgs e)
        {
            string OAuthUrl = @"https://www.facebook.com/logout.php?next=https://www.facebook.com/connect/login_success.html&access_token=" + Settings1.Default.AccessToken;
            webLogout.Navigate(OAuthUrl);
        }
    }
}
