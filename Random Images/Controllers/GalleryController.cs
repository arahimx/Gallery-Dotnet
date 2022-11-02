using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace Random_Images.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery

        public ActionResult Index()
        {
            string salesFTPPath = "C:\\Users\\LENOVO\\source\\repos\\Random Images\\Random Images\\Content\\assets";
            DirectoryInfo salesFTPDirectory = new DirectoryInfo(salesFTPPath);
            IEnumerable<string> files = salesFTPDirectory.GetFiles()
              .Where(f => f.Extension == ".gif" || f.Extension == ".wave" || f.Extension == ".mp4" || f.Extension == ".jpg" || f.Extension == ".jpeg" || f.Extension == ".png")
              .OrderBy(f => f.Name)
              .Select(f => f.FullName);
            ViewBag.max = files.Count();
            return View();
        }
        [HttpGet]
        public JsonResult indexs()
        {
            string salesFTPPath = "C:\\Users\\LENOVO\\source\\repos\\Random Images\\Random Images\\Content\\assets";
            DirectoryInfo salesFTPDirectory = new DirectoryInfo(salesFTPPath);
            IEnumerable<string> files = salesFTPDirectory.GetFiles()
              .Where(f => f.Extension == ".gif" || f.Extension == ".wave" || f.Extension == ".mp4" || f.Extension == ".jpg" || f.Extension == ".jpeg" || f.Extension == ".png")
              .OrderBy(f => f.Name)
              .Select(f => f.FullName);
            return Json(files.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}