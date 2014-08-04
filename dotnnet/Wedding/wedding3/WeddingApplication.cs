using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace wedding3
{
    public class WeddingApplication : Umbraco.Web.UmbracoApplication
    {
        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            RouteTable.Routes.MapRoute(
               name: "Default",
               url: "person/{id}",
               defaults: new { controller = "Person", action = "Index", id = UrlParameter.Optional }
           );
            base.OnApplicationStarted(sender, e);
        }
    }
}