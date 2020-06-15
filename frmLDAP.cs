using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.Protocols;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_ModernAuth
{
    public partial class frmLDAP : Form
    {
        String loggedInUser = "";
        public frmLDAP()
        {
            InitializeComponent();
        }

        public string LoggedInUser { get => loggedInUser; }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var ldapServer = System.Configuration.ConfigurationManager.AppSettings["ldapserver"];
            var ou = System.Configuration.ConfigurationManager.AppSettings["ou"];

            var userDN = "uid=" + txtUsername.Text + "," + ou;
            var credentials = new NetworkCredential(userDN, txtPassword.Text);
            var serverId = new LdapDirectoryIdentifier(ldapServer, 636);


            StringBuilder output = new StringBuilder();

            var conn = new LdapConnection(serverId);
            conn.SessionOptions.SecureSocketLayer = true;
            conn.SessionOptions.VerifyServerCertificate += delegate { return true; };
            conn.AuthType = AuthType.Basic;
            try
            {
                conn.Bind(credentials);
                SearchRequest req = new SearchRequest(ou, "(uid=" + txtUsername.Text + ")", SearchScope.OneLevel, null);
                SearchResponse resp = (SearchResponse)conn.SendRequest(req);
                output.AppendLine("");
            
                foreach(DirectoryAttribute attr in resp.Entries[0].Attributes.Values){
                    String attrValue = attr.Name + ": ";
                    
                    foreach(Object val in attr)
                    {
                        attrValue += System.Text.Encoding.Default.GetString((byte[]) val) + ",";
                    }
                    output.AppendLine(attrValue.TrimEnd(','));
                }
  
            }
            catch (Exception ex)
            {
                this.loggedInUser = ex.Message;
                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }
            finally
            {
                conn.Dispose();
            }

            this.DialogResult = DialogResult.OK;
            this.loggedInUser = output.ToString();
            this.Close();
            return;
        }
    }
}
