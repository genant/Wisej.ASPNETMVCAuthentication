using Microsoft.AspNet.Identity.Owin;
using System;
using System.Web;
using Wisej.Web;


namespace Wisej.ASPNETMVCAuthentication.WisejViews {
    public partial class LoginPage : Page {
        public LoginPage() {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e) {
            var SignInManager = HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = SignInManager.PasswordSignIn(txtUserName.Text, txtPassword.Text, true, shouldLockout: false);
            switch (result) {
                case SignInStatus.Success:
                    Application.Navigate("/wisej");
                    break;
                case SignInStatus.LockedOut:
                //return View("Lockout");
                case SignInStatus.RequiresVerification:
                //return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                case SignInStatus.Failure:
                default:
                    MessageBox.Show($"Invalid login attempt: {result}");
                    break;
            }

        }
    }
}
