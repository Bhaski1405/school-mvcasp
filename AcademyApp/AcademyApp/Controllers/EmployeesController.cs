using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademyApp.Entities;
using AcademyApp.Models;

namespace AcademyApp.Controllers
{
    public class EmployeesController : Controller
    {
       
        public ActionResult Index()
        {
            List<string> aliases = new List<string>();
            using (academycontext db = new academycontext()) {
               aliases = db.Employees.Select(x => x.Alias).ToList<string>();
            }
            //this is theplace where we put in all the logic to collect the employees from the store
            return View("Index", aliases);
        }

    }
}
