using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Wisej.Web;

namespace Wisej.ASPNETMVCAuthentication {
    public class RequireSessionHttpHandler : IHttpAsyncHandler, IHttpHandler {
        private readonly Core.HttpHandler httpHandler;
        public RequireSessionHttpHandler() {
            httpHandler = new Core.HttpHandler();
        }
        public bool IsReusable => false; // httpHandler.IsReusable;

        public IAsyncResult BeginProcessRequest(HttpContext context, AsyncCallback cb, object extraData) {
            if (!context.User.Identity.IsAuthenticated) {
                _Delegate = new AsyncProcessorDelegate(ProcessRequest);
                return _Delegate.BeginInvoke(context, cb, extraData);
            }
            return httpHandler.BeginProcessRequest(context, cb, extraData);
        }

        public void EndProcessRequest(IAsyncResult result) {
            if(_Delegate != null) {
                _Delegate.EndInvoke(result);
                _Delegate = null;
            } else {
                httpHandler.EndProcessRequest(result);
            }
        }

        public void ProcessRequest(HttpContext context) {
            if (!context.User.Identity.IsAuthenticated) {
                context.Response.StatusCode = 403;
                context.Response.End();
                //context.Response.RedirectPermanent("~/Account/Login");
                return;
            }
            httpHandler.ProcessRequest(context);
        }



        private AsyncProcessorDelegate _Delegate;

        protected delegate void AsyncProcessorDelegate(HttpContext context);
    }
}