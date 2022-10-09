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
            //ViewBag.Id = 8;
            //ViewBag.Avatar = "🧙";
            //ViewBag.PlayerName = "Gandalf Mithrandir";
            //ViewBag.Points = 1298;

            List<Score> modelo = new List<Score>
            {
                new Score(8, "🧙", "Gandalf Mithrandir", 1298),
                new Score(1, "🧝", "Legolas Greenleaf", 800),
                new Score(7, "👦", "Frodo Baggins", 765),
                new Score(3, "🧝‍♀️", "Galadriel Alatáriel", 721)
            };

            // CRIAÇÃO DA CLASSE RankingService NÃO FOI MOSTRADA EM NUNHUM DOS VÍDEOS!!!
            //var modelo = RankingService.Instance().GetAll();
            return View(modelo);
        }

        [HttpGet]
        public ActionResult NovoScore()
        {
            var modelo = new NewScoreViewModel();
            return View(modelo);
        }

        [HttpPost]
        public ActionResult NovoScore(Score input)
        {
            // CRIAÇÃO DA CLASSE RankingService NÃO FOI MOSTRADA EM NUNHUM DOS VÍDEOS!!!
            //RankingService.Instance().Create(input);
            return Redirect("/Ranking");
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