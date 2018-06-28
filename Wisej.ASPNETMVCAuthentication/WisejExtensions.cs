using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

using Wisej.Web;

namespace Wisej.ASPNETMVCAuthentication {
    internal static class WisejExtensions {
        private const string SessionIdClaim = "Microsoft.Owin.Security.Cookies-SessionId";

        public static ClaimsIdentity User(this Page page) {
            var authCookie = Application.Cookies[".AspNet.ApplicationCookie"];
            if (authCookie == null) {
                return new ClaimsIdentity();
            }
            var ticket = Startup.Options.TicketDataFormat.Unprotect(authCookie);

            Claim claim = ticket.Identity.Claims.FirstOrDefault(c => c.Type.Equals(SessionIdClaim));

            if (claim == null) {
                System.Diagnostics.Trace.TraceWarning(@"SessionId missing");
                return new ClaimsIdentity();
            }
            string sessionKey = claim.Value;
            ticket = AsyncHelper.RunSync(() => Startup.Options.SessionStore.RetrieveAsync(sessionKey));
            if (ticket == null) {
                System.Diagnostics.Trace.TraceWarning(@"Identity missing in session store");
                return new ClaimsIdentity();
            }
            return ticket.Identity;
        }
    }
}