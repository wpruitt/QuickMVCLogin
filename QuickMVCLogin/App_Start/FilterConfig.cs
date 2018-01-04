using System.Web;
using System.Web.Mvc;

namespace QuickMVCLogin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Applies Authorization to entire application
            //must use [AllowAnonymous] to override on specific areas
            filters.Add(new System.Web.Mvc.AuthorizeAttribute());
        }
    }
}
