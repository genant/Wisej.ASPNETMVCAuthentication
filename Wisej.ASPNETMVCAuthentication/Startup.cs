using Microsoft.Owin;
using Owin;
using System.Web;
using System.Web.Services;
using Wisej.ASPNETMVCAuthentication.WisejViews;
using Wisej.Web;

[assembly: OwinStartupAttribute(typeof(Wisej.ASPNETMVCAuthentication.Startup))]
namespace Wisej.ASPNETMVCAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
            Application.BeginRequest += Application_BeginRequest;
            if (Application.IsAuthenticated) {
                Application.MainPage = new Page1();
            } else {
                Application.MainPage = new LoginPage();
            }
        }

        [WebMethod]
        public static void LoggedOut() {
            Application.Navigate("/Home/Index");
        }
        private static void Application_BeginRequest(object sender, System.EventArgs e) {
            if(!Application.IsAuthenticated && Application.MainPage.GetType() != typeof(LoginPage)) {
                Application.MainPage = new LoginPage();
            }
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}
