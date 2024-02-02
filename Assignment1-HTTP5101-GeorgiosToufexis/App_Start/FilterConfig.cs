using System.Web;
using System.Web.Mvc;

namespace Assignment1_HTTP5101_GeorgiosToufexis
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
