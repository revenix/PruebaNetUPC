using System.Web;
using System.Web.Mvc;

namespace SOL_MOISES_SULLCA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
