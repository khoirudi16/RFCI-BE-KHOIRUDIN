using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleClientServer.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateData(string counter)
        {
            var header = Request.Headers;
            var xRandom = header.GetValues("X-RANDOM")[0];

            DateTime dateNow = DateTime.Now;
            string url = "https://localhost:44328/";

            string message = "[" + dateNow + "] Success: POST " + url + " {" + "\"counter\": " + counter + ", \"X-RANDOM\": " + xRandom + "}";

            bool result = WriteLog(message);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public static bool WriteLog(string message)
        {
            try
            {
                //Sesuaikan dengan path local
                string path = "D:\\Learning\\Csharp\\SimpleClientServer\\SimpleClientServer\\SimpleClientServer\\Log\\Message.txt";
                string strMessage = String.Format("{0}", message);
                FileStream objFilestream = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                objStreamWriter.WriteLine(strMessage);
                objStreamWriter.Close();
                objFilestream.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}