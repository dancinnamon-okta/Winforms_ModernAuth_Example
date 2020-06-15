using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdentityModel.OidcClient;
using IdentityModel.OidcClient.Browser;

namespace Winforms_ModernAuth
{
    public partial class frmAuth : Form
    {
        public frmAuth()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            IBrowser browser;
            String redirectUrl;
            if(rdoEmbedded.Checked)
            {
                browser = new WinFormsEmbeddedBrowser(title: "Authenticating with modern auth...", width: 400, height: 650);
                redirectUrl = "http://localhost/winforms.client";
            }
            //else
            {
                browser = new SystemBrowser(Int16.Parse(System.Configuration.ConfigurationManager.AppSettings["callback_port"]));
                redirectUrl = "http://localhost:" + System.Configuration.ConfigurationManager.AppSettings["callback_port"] + "/";
            }
          
            var options = new OidcClientOptions
            {
                Authority = System.Configuration.ConfigurationManager.AppSettings["okta_org"],
                ClientId = System.Configuration.ConfigurationManager.AppSettings["client_id"],
                RedirectUri = redirectUrl,
                Scope = System.Configuration.ConfigurationManager.AppSettings["scopes"],
                Browser = browser,
                Flow = OidcClientOptions.AuthenticationFlow.AuthorizationCode,
                LoadProfile = true
            };
            var client = new OidcClient(options);
            var result = await client.LoginAsync(new LoginRequest { BrowserDisplayMode = DisplayMode.Visible });

            if (result.IsError)
            {
                MessageBox.Show(this, result.Error, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var b64_access_token = result.AccessToken.Split('.')[1];

                var id_sb = new StringBuilder();
                var access_sb = new StringBuilder();

                if (b64_access_token.Length % 4 > 0)
                {
                    b64_access_token += new string('=', 4 - (b64_access_token.Length % 4));
                }
   
                var access_bytes = System.Convert.FromBase64String(b64_access_token);
                var access_utf_lines = Encoding.UTF8.GetString(access_bytes).Split(',');

                foreach (Claim c in result.User.Claims)
                {
                    id_sb.AppendLine(c.ToString());
                }

                foreach (string ln in access_utf_lines)
                {
                    access_sb.AppendLine(ln);
                }

                txtIDToken.Text = id_sb.ToString();
                txtAccessToken.Text = access_sb.ToString();
                lblWelcome.Text = "Welcome " + result.User.Identity.Name;
                lblWelcome.Show();
            }
        }

        private void BtnLDAP_Click(object sender, EventArgs e)
        {
            frmLDAP loginDialog = new frmLDAP();
            if (loginDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtIDToken.Text = "User login via LDAP successful! User: " + loginDialog.LoggedInUser;
            }
            else
            {
                txtIDToken.Text = "User login via LDAP failed: " + loginDialog.LoggedInUser;
            }
        }
    }
}
