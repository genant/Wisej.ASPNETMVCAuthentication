namespace Wisej.ASPNETMVCAuthentication.WisejViews
{
	partial class MainPage
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.button1 = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.btnLogout = new Wisej.Web.LinkLabel();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnLogout.AutoSize = true;
            this.btnLogout.Location = new System.Drawing.Point(-52, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(49, 16);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.btnLogout_LinkClicked);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Button button1;
		private Web.Label label1;
        private Web.LinkLabel btnLogout;
        private Web.JavaScript javaScript1;
    }
}
