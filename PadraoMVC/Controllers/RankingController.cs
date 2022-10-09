using PadraoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PadraoMVC.Controllers
{
    public class RankingController : Controller
    {
        // ViewResult - Representa HTML
        public ActionResult Index()
        {
            var modelo = RankingService.Instance().GetAll();
            return View(modelo);
        }

        [HttpGet]
        public ActionResult NovoScore()
        {
            var modelo = new NewScoreViewModel();
            return View(modelo);
        }

        [HttpPost]
        public ActionResult NovoScore(NewScoreViewModel input)
        {
            if (ModelState.IsValid)
            {
                RankingService.Instance().Create(input.NewScore);
                return Redirect("/Ranking");
            }
            else
            {
                var modelo = new NewScoreViewModel();
                return View(modelo);
            }
        }

        // EmptyResult - não representa nenhum resultado
        public ActionResult Vazio()
        {
            return new EmptyResult();
        }

        // RedirectResult - redirecionamento para outra URL
        public ActionResult VaiPraHome()
        {
            return Redirect("/Home/Index");
        }

        // JsonResult - objeto na notação JSON
        public ActionResult Json()
        {
            var obj = new { id = 1234, nome = "John Doe" };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        // ContentResult - resultado de texto
        public ActionResult OlaMundo()
        {
            return Content("Olá, Mundo!");
        }

        // FileContentResult - arquivo para download
        public ActionResult Logo()
        {
            var path = Server.MapPath("~/images/logo-frodo-corretor-imobiliario@2x.png");
            var contentType = "data:image/png;base64,{0}";
            return File(path, contentType, "logo.png");
        }
    }
}