using Wisej.ASPNETMVCAuthentication.WisejViews;
using Wisej.Web;
using System.Web;

namespace Wisej.ASPNETMVCAuthentication {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main() {
            if (Application.IsAuthenticated) {
                Application.MainPage = new MainPage();
            } else {
                Application.Navigate(VirtualPathUtility.ToAbsolute("~/Account/Login"));
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