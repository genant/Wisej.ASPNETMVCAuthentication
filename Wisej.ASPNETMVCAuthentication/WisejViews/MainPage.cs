using Microsoft.AspNet.Identity;
using System;
using System.Drawing;
using Wisej.Web;
using Wisej.Core;


namespace Wisej.ASPNETMVCAuthentication.WisejViews {
    public partial class MainPage : Page
	{
        public MainPage()
		{
			InitializeComponent();

            Application.BrowserTabActivated += Application_BrowserTabActivated;
        }

        private void button1_Click(object sender, EventArgs e)
		{
			if (Application.IsAuthenticated)
			{
                var name = this.User().GetUserName();
				AlertBox.Show($"You are authenticated as {name}", alignment: ContentAlignment.MiddleCenter);
			}
			else
			{
				AlertBox.Show("You are NOT authenticated.", alignment: ContentAlignment.MiddleCenter);
			}
		}

		private void Page1_Load(object sender, EventArgs e)
		{
 
            // will be like this once Application exposes the user identity.
            // var name = Application.User.Identity.GetUserName();
            var name = this.User().GetUserName();
			this.label1.Text = name;
		}

		private void Application_BrowserTabActivated(object sender, EventArgs e)
		{
            // will be like this once Application exposes the user identity.
            // var name = Application.User.Identity.GetUserName();
            string name;
            if(this.User().IsAuthenticated) {
                name = this.User().GetUserName();
                this.label1.Text = name;
            } else {
                Application.Navigate("/Home/Index");
            }
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //Eval(@"var req = new qx.io.request.Xhr('/Account/SignOut');
            //       req.addListener('success', App.Page1.LogoutSuccess(), this);
            //       req.send();");
            Eval("qx.datev.Account.logOff();");
        }

        [WebMethod]
        public void LogoutSuccess() {
            Application.Navigate("/Home/Index");
        }
    }
}
