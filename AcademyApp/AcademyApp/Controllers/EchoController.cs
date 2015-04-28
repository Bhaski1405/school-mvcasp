using AcademyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademyApp.Controllers
{
    public class EchoController : Controller
    {
        //
        // GET: /Echo/
        //HTTPGET HTTPPUT, HTTPPOST, HTTPDELETE

        [HttpGet]
        public ActionResult Hello()
        {
            return View("Hello");
        }

        public ActionResult Greet(string userName) {
            GreetModel vm = new GreetModel() { Greeting = "Hi there " + userName };
            return View("Greet", vm);
        }

        public ActionResult GreetUser(UserModel u)
        {
            GreetModel vm = new GreetModel()
            {Greeting = String.Format("Hi there {0} from {1}, how is {2} project doing?",
                u.Name, u.Location, u.Project)};
            return View("Greet", vm);
        }
    }
}
