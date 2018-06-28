using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wisej.ASPNETMVCAuthentication.Startup))]
namespace Wisej.ASPNETMVCAuthentication {
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
