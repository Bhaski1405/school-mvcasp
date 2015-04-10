using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademyApp.Models;

namespace AcademyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            IndexModel vm = new IndexModel()
            {CustomMessage="This is hello from localhost3436"};

            return View("Index",vm);
        }

        public ActionResult About() {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
