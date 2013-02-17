using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Καλωσόρισες επισκέπτη!";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Βιογραφικό";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Στοιχεία επικοινωνίας";

            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Message = "Ρυθμίσεις";

            return View();
        }
    }
}
