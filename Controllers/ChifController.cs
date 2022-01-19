using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Village.Controllers.API
{
    public class ChifController : Controller
    {
        // GET: Chif
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowChif()
        {
           ViewBag.name=" welcom Chif";
            return View(ViewBag);
        }
    }
}