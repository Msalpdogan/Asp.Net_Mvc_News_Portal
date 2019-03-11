using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace obajans.Controllers
{
    public class XmlController : Controller
    {
        // GET: Xml
        public ContentResult Index()
        {
            string xml = System.IO.File.ReadAllText(Server.MapPath("~/sitemap.xml"));
            return Content(xml);
        }
    }
}