using System;
using System.Web.Mvc;

namespace CrithchlowDevTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Critchlow";

            return View();
        }
    }
}
