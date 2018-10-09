using ProjectAdmin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace ProjectAdmin.Controllers
{
    public class ContaController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Conta
        public ActionResult Perfil(string id)
        {
            ApplicationUser user = db.Users.Find(id);
            return View(user);
        }
        public ActionResult Definicoes(string id)
        {
            ApplicationUser user = db.Users.Find(id);
            return View(user);
        }


        #region Upload Photo

        [HttpPost]
        public async Task<ActionResult> UploadPhoto(HttpPostedFileBase file, string nome,string id)
        {
            var Usuario = db.Users.Find(id);
            if (file != null && file.ContentLength > 0)
            {
                var user = nome;
                var username = user;
                var fileExt = Path.GetExtension(file.FileName);
                var fnm = username + ".png";
                if (fileExt.ToLower().EndsWith(".png") || fileExt.ToLower().EndsWith(".jpg") || fileExt.ToLower().EndsWith(".gif"))// Important for security if saving in webroot
                {
                    var filePath = HostingEnvironment.MapPath("~/Imagens/") + fnm;
                    var directory = new DirectoryInfo(HostingEnvironment.MapPath("~/Imagens/"));
                    if (directory.Exists == false)
                    {
                        directory.Create();
                    }
                    ViewBag.FilePath = filePath.ToString();
                    file.SaveAs(filePath);
                    return RedirectToAction("Definicoes","Conta", new { id=id});
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");// PRG
        }

        [HttpPost]
        public async Task<ActionResult> UploadPhotoCapa(HttpPostedFileBase file, string nome, string id)
        {
            var Usuario = db.Users.Find(id);
            if (file != null && file.ContentLength > 0)
            {
                var user = id;
                var username = user;
                var fileExt = Path.GetExtension(file.FileName);
                var fnm = username + ".png";
                if (fileExt.ToLower().EndsWith(".png") || fileExt.ToLower().EndsWith(".jpg") || fileExt.ToLower().EndsWith(".gif"))// Important for security if saving in webroot
                {
                    var filePath = HostingEnvironment.MapPath("~/Imagens/") + fnm;
                    var directory = new DirectoryInfo(HostingEnvironment.MapPath("~/Imagens/"));
                    if (directory.Exists == false)
                    {
                        directory.Create();
                    }
                    ViewBag.FilePath = filePath.ToString();
                    file.SaveAs(filePath);
                    return RedirectToAction("Definicoes", "Conta", new { id = id });
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");// PRG
        }

        #endregion Upload Photo
    }
}