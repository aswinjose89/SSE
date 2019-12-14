using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Mvc;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;

namespace SSE.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to Server Sent Event(SSE) in ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Streaming()
        {
            return View();
        }



    }
}
