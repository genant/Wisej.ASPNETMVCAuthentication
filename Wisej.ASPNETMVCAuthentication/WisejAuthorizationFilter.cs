using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace Wisej.ASPNETMVCAuthentication {
    public class WisejAuthorizationFilter : IAuthorizationFilter {
        public void OnAuthorization(AuthorizationContext filterContext) {
            if (filterContext == null) {
                throw new ArgumentNullException("filterContext");
            }
            if(filterContext.HttpContext.Request.Path.Equals("/Wisej.html")) {
                if (AuthorizeCore(filterContext.HttpContext)) {
                    HttpCachePolicyBase cache = filterContext.HttpContext.Response.Cache;
                    cache.SetProxyMaxAge(new TimeSpan(0L));
                    cache.AddValidationCallback(new HttpCacheValidateHandler(this.CacheValidateHandler), null);
                } else {
                    this.HandleUnauthorizedRequest(filterContext);
                }

            }
        }

        private void CacheValidateHandler(HttpContext context, object data, ref HttpValidationStatus validationStatus) {
            validationStatus = this.OnCacheAuthorization(new HttpContextWrapper(context));
        }

        protected virtual HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext) {
            if (httpContext == null) {
                throw new ArgumentNullException("httpContext");
            }
            if (!this.AuthorizeCore(httpContext)) {
                return HttpValidationStatus.IgnoreThisRequest;
            }
            return HttpValidationStatus.Valid;
        }

        protected virtual void HandleUnauthorizedRequest(AuthorizationContext filterContext) {
            filterContext.Result = new HttpUnauthorizedResult();
        }

        protected virtual bool AuthorizeCore(HttpContextBase httpContext) {
            if (httpContext == null) {
                throw new ArgumentNullException("httpContext");
            }
            IPrincipal user = httpContext.User;
            if (!user.Identity.IsAuthenticated) {
                return false;
            }

            /* TODO: verifica i ruoli utente */
            return true;
        }
    }

    //public class WisejAuthorizationFilter : AuthorizeAttribute {
    //    protected override bool AuthorizeCore(HttpContextBase httpContext) {
    //        bool result = base.AuthorizeCore(httpContext);

    //        if(!httpContext.User.Identity.IsAuthenticated) {
    //            // TODO: custom authentication rules goes here!
    //            result = false;
    //        }

    //        return result;
    //    }

    //    public override void OnAuthorization(AuthorizationContext filterContext) {
    //        if (filterContext == null) {
    //            throw new ArgumentNullException("filterContext");
    //        }
    //        if (OutputCacheAttribute.IsChildActionCacheActive(filterContext)) {
    //            throw new InvalidOperationException("MvcResources.AuthorizeAttribute_CannotUseWithinChildActionCache");
    //        }
    //        if (!filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true) && !filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true)) {
    //            if (this.AuthorizeCore(filterContext.HttpContext)) {
    //                HttpCachePolicyBase cache = filterContext.HttpContext.Response.Cache;
    //                cache.SetProxyMaxAge(new TimeSpan(0L));
    //                cache.AddValidationCallback(new HttpCacheValidateHandler(this.CacheValidateHandler), null);
    //            } else {
    //                this.HandleUnauthorizedRequest(filterContext);
    //            }
    //        }
    //    }





    //}
}