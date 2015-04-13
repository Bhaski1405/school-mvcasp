using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademyApp.Models;
using AcademyApp.EF;

namespace AcademyApp.Controllers
{
    public class EmployeesController : Controller
    {
        //
        // GET: /Employees/

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

    }
}
