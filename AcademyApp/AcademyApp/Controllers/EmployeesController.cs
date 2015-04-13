using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademyApp.Models;
using AcademyApp.EF;
using System.Web.Http;
using System.Web.Mvc;

namespace AcademyApp.Controllers
{
    public class EmployeesController : Controller
    {
        //
        // GET: /Employees/
        [System.Web.Mvc.HttpGet]
        public ActionResult Index()
        {   
            using(collabcontext db = new collabcontext())
	        {
		        var employees = db.Employees.Select(x=>x);
                EmployeeModel vm = new EmployeeModel(){
                    Result = employees.ToList<Employee>()
                };
                return View("Index", vm);
	        }
            
        }
        public ActionResult Search(int SearchPhrase) {

            using (collabcontext db = new collabcontext()) {
                var result = db.Employees.Where(x => x.Id == SearchPhrase).Select(x => x);
                EmployeeModel vm = new EmployeeModel() {Result=result.ToList<Employee>() };
                return View("Index", vm);

            }
        }
    }
}
