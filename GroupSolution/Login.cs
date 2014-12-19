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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void webFacebook_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webFacebook.Url.AbsoluteUri.Contains("access_token"))
            {
                string Url1 = webFacebook.Url.AbsoluteUri;
                string url2 = Url1.Substring(Url1.IndexOf("access_token") + 13);
                string access = url2.Substring(0, url2.IndexOf("&"));
                Settings1.Default.AccessToken = access;
                btnMaster.IsLogin = true;
                btnMaster.IsBackFromLogin = true;
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string OAuthUrl = @"https://www.facebook.com/dialog/oauth?client_id=" + Settings1.Default.AppID + "&response_type=token&redirect_uri=https://www.facebook.com/connect/login_success.html&scope=" + Settings1.Default.Scope;
            webFacebook.Navigate(OAuthUrl);
        }
    }
}
