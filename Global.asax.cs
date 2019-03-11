using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace obajans
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

       /* protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if (ex is HttpException && ((HttpException)ex).GetHttpCode() == 404)
            {
                Response.Redirect("~/Error/Page404");
            }
            if (ex is HttpException && ((HttpException)ex).GetHttpCode() == 403)
            {
                Response.Redirect("~/Error/Page403");
            }
            if (ex is HttpException && ((HttpException)ex).GetHttpCode() == 500)
            {
                Response.Redirect("~/Error/Page500");
            }
            else if (ex is HttpException)
            {
                Response.Redirect("~~/Error/NotFound");
            }
        }*/
    }
}
