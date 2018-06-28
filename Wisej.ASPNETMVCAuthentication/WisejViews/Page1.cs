using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.DataHandler.Serializer;
using System;
using System.Drawing;
using System.Web;
using Wisej.Web;
using System.Text;
using System.IO;
using System.Security.Claims;
using System.IO.Compression;
using Microsoft.Owin.Security;
using System.Linq;
using Wisej.ASPNETMVCAuthentication;
using System.Web.Services;

namespace Wisej.ASPNETMVCAuthentication.WisejViews
{
	public partial class Page1 : Page
	{
        public Page1()
		{
			InitializeComponent();
            Application.BeginRequest += Application_BeginRequest;
		}

        private void Application_BeginRequest(object sender, EventArgs e) {
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
            Application.BrowserTabActivated += Application_BrowserTabActivated;

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
            Eval(@"
    var req = new qx.io.request.Xhr('/Account/SignOut');
    req.addListener('success', function(e) 
    {
        console.log(req.getResponse());
        App.loggedOut();
    }, this);
    req.send();");
            //Call("logOff");
            /*
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            Application.Navigate("/Home/Index");*/
        }

        [WebMethod]
        public void LogoutSuccess() {
            Application.Navigate("/Home/Index");
        }
    }
}
