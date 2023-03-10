using System.Web;
using System.Web.Mvc;

namespace TH_2080600752_NguyenNguyenTrung
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
