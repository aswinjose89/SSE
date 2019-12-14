using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using SSE.Models;


namespace SSE.Controllers
{
    public class StreamingController : Controller
    {
        //
        // GET: /Streaming/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult sseEvent()
        {
            var sb = new StringBuilder();
            string emptyData = null;
            JavaScriptSerializer ser = new JavaScriptSerializer();
            if (!string.IsNullOrEmpty(StreamModel.dataHolder))
            {
                var serializedObject = ser.Serialize(new { result = StreamModel.dataHolder, status = "success" });
                sb.AppendFormat("data: {0}\n\n", serializedObject);
            }
            else
            {
                var serializedObject = ser.Serialize(new { result = emptyData, status = "success" });
                sb.AppendFormat("data: {0}\n\n", serializedObject);
            }
            return Content(sb.ToString(), "text/event-stream");
        }

        [HttpGet]
        public JsonResult sseDataUpdate(string bridgeData)
        {
            StreamModel.dataHolder = Request.QueryString["userInputData"];
            return Json(new { Result = "Ajax Call Passed Value to the event Listener successfully.." }, JsonRequestBehavior.AllowGet);
        }

    }
}
