using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Random_Images.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var path = Server.MapPath("/Content/assets");
            int fileCount = Directory.GetFiles(path, "*.*").Length;
            ViewBag.max= fileCount;
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(int e)
        //{
        //    String fileName = "~/Content/Images/Image.png";
        //    fileName = Server.MapPath(fileName);
        //    if (File.Exists(fileName))
        //    {
        //        using (Bitmap bmp = new Bitmap(fileName))
        //        using (Graphics g = Graphics.FromImage(bmp))
        //        {
        //            // do stuff here
        //        }
        //    }
        //    return View()
        //}
    }
}