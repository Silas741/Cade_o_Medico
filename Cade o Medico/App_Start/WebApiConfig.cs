using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

using System.Web.Http;

namespace Cade_o_Medico.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)

        {

            config.Routes.MapHttpRoute(

                name: "DefaultApi",

                routeTemplate: "api/{controller}/{id}",

                defaults: new { id = System.Web.Http.RouteParameter.Optional }

            );
        }
    }
}