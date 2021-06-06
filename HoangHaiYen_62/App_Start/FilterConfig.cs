using System.Web;
using System.Web.Mvc;

namespace HoangHaiYen_62
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
