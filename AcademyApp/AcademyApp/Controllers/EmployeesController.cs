using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademyApp.Models;

namespace AcademyApp.Controllers
{
    public class EmployeesController : Controller
    {
        //
        // GET: /Employees/

        public ActionResult Index()
        {
            EmployeeIndex vm = new EmployeeIndex() {
                Names = new List<string>(){
                    "Niranjan",
                    "Pragya",
                    "Arun",
                    "Paul",
                    "Maharaja",
                    "Avinash"
                }
            };
            return View("Index", vm);
        }

    }
}
