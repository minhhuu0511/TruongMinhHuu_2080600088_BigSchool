using System.Web;
using System.Web.Mvc;

namespace TruongMinhHuu_2080600088
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
