namespace Wisej.ASPNETMVCAuthentication.WisejViews {
    partial class LoginPage {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.button1 = new Wisej.Web.Button();
            this.linkLabel1 = new Wisej.Web.LinkLabel();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.txtUserName = new Wisej.Web.TextBox();
            this.txtPassword = new Wisej.Web.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 198);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.Text = "Password dimenticata?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome utente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(7, 57);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.Location = new System.Drawing.Point(7, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(271, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(1078, 849);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.GroupBox groupBox1;
        private Web.TextBox txtPassword;
        private Web.TextBox txtUserName;
        private Web.Label label2;
        private Web.Label label1;
        private Web.LinkLabel linkLabel1;
        private Web.Button button1;
    }
}
