using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Wisej.ASPNETMVCAuthentication.Models;

namespace Wisej.ASPNETMVCAuthentication {
    public class IoC {
        private static KernelBase _kernel;

        static IoC() {
            _kernel = new StandardKernel();
            _kernel.Load(new ServiceBindings());
        }


        public static T Get<T>() {
            return _kernel.Get<T>();
        }


        class ServiceBindings : NinjectModule {
            public override void Load() {
                Bind<DbContext>().To<ApplicationDbContext>();
                Bind<IdentityDbContext<ApplicationUser>>().To<ApplicationDbContext>();
                Bind<IUserStore<ApplicationUser>>().To<UserStore<ApplicationUser>>();
                Bind<ApplicationSignInManager>().ToSelf();
                Bind<ApplicationUserManager>().ToSelf();
                Bind<IAuthenticationManager>().To<AuthenticationManager>();
            }
        }
    }
}