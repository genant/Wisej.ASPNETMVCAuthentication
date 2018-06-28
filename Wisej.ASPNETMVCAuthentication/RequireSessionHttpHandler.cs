using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej.ASPNETMVCAuthentication {
    public class RequireSessionHttpHandler : Core.HttpHandler, System.Web.SessionState.IRequiresSessionState {
    }
}