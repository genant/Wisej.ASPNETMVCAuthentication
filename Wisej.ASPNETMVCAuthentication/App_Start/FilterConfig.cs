using System.Web;
using System.Web.Mvc;

namespace Wisej.ASPNETMVCAuthentication
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
            //filters.Add(new WisejAuthorizationFilter());
		}
	}
}
