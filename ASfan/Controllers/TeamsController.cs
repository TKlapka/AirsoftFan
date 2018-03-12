using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASfan.Controllers
{
    public class TeamsController : Controller
    {
        // GET: Teams
        public ActionResult Index(int? page, string sortBy)
        {
            if (!page.HasValue)
                page = 1;

            if (string.IsNullOrEmpty(sortBy))
                sortBy = "Kraj";

            return View();
        }

        public ActionResult Team(string name)
        {
            return View();
        }
    }
}