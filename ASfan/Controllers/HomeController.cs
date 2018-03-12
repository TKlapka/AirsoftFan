using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASfan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pokud máte nějaký připomínky, nápady ke zlepšení nebo se chcete stát jedním z redaktorů webu,\n napište nám na uvedené kontaktní informace.";

            return View();
        }
    }
}