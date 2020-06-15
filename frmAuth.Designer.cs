namespace Winforms_ModernAuth
{
    partial class frmAuth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDToken = new System.Windows.Forms.TextBox();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.rdoEmbedded = new System.Windows.Forms.RadioButton();
            this.rdoSystem = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLDAP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(274, 399);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login with OIDC";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Access Token";
            // 
            // txtIDToken
            // 
            this.txtIDToken.Location = new System.Drawing.Point(23, 56);
            this.txtIDToken.Multiline = true;
            this.txtIDToken.Name = "txtIDToken";
            this.txtIDToken.ReadOnly = true;
            this.txtIDToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIDToken.Size = new System.Drawing.Size(637, 147);
            this.txtIDToken.TabIndex = 3;
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(23, 233);
            this.txtAccessToken.Multiline = true;
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.ReadOnly = true;
            this.txtAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAccessToken.Size = new System.Drawing.Size(637, 147);
            this.txtAccessToken.TabIndex = 4;
            // 
            // rdoEmbedded
            // 
            this.rdoEmbedded.AutoSize = true;
            this.rdoEmbedded.Checked = true;
            this.rdoEmbedded.Location = new System.Drawing.Point(6, 16);
            this.rdoEmbedded.Name = "rdoEmbedded";
            this.rdoEmbedded.Size = new System.Drawing.Size(117, 17);
            this.rdoEmbedded.TabIndex = 5;
            this.rdoEmbedded.TabStop = true;
            this.rdoEmbedded.Text = "Embedded Browser";
            this.rdoEmbedded.UseVisualStyleBackColor = true;
            // 
            // rdoSystem
            // 
            this.rdoSystem.AutoSize = true;
            this.rdoSystem.Location = new System.Drawing.Point(6, 39);
            this.rdoSystem.Name = "rdoSystem";
            this.rdoSystem.Size = new System.Drawing.Size(100, 17);
            this.rdoSystem.TabIndex = 6;
            this.rdoSystem.Text = "System Browser";
            this.rdoSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoEmbedded);
            this.groupBox1.Controls.Add(this.rdoSystem);
            this.groupBox1.Location = new System.Drawing.Point(426, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(20, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(125, 20);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome User";
            this.lblWelcome.Visible = false;
            // 
            // btnLDAP
            // 
            this.btnLDAP.Location = new System.Drawing.Point(124, 399);
            this.btnLDAP.Name = "btnLDAP";
            this.btnLDAP.Size = new System.Drawing.Size(131, 23);
            this.btnLDAP.TabIndex = 9;
            this.btnLDAP.Text = "Login with Okta LDAP";
            this.btnLDAP.UseVisualStyleBackColor = true;
            this.btnLDAP.Click += new System.EventHandler(this.BtnLDAP_Click);
            // 
            // frmAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.btnLDAP);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.txtIDToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmAuth";
            this.Text = "Windows Forms Modern Auth Example";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDToken;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.RadioButton rdoEmbedded;
        private System.Windows.Forms.RadioButton rdoSystem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLDAP;
    }
}

