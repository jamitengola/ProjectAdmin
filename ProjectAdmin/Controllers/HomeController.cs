using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Upload(HttpPostedFileBase file)
        {
            string filePath = file.FileName + Path.GetExtension(file.FileName);
            file.SaveAs(Path.Combine(Server.MapPath("~/img"), filePath));
            return Json("Carregado com Sucesso");
        }
    }
}