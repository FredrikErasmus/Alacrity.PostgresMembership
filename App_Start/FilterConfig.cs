using System.Web;
using System.Web.Mvc;

namespace Alacrity.PostgresMembership
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
