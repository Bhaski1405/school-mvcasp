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
        [System.Web.Mvc.HttpGet]
        public ActionResult Search(int SearchPhrase) {

            using (collabcontext db = new collabcontext()) {
                var result = db.Employees.Where(x => x.Id == SearchPhrase).Select(x => x);
                EmployeeModel vm = new EmployeeModel() {Result=result.ToList<Employee>() };
                return View("Index", vm);

            }
        }
        [System.Web.Mvc.HttpGet]
        public ActionResult Add() {
            return View("Add");
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult Add(Employee toAdd) {
            using (collabcontext db = new collabcontext()) {
                //getting a new employee model -dummy
                EmployeeModel vm = new EmployeeModel() {
                    Result = new List<Employee>()
                };
                if (toAdd !=null) {
                    bool isAlready = db.Employees
                        .Where(x => x.Id == toAdd.Id)
                        .Count() != 0;
                    if (!isAlready) {
                        if (!String.IsNullOrEmpty(toAdd.Email) && !String.IsNullOrEmpty(toAdd.Alias)) {
                            db.Employees.Add(toAdd);
                            try {
                                db.SaveChanges();
                                vm.Result = db.Employees.ToList<Employee>();
                                return View("Index", vm);
                            }
                            catch (Exception x) {
                                return View();
                            }
                        } 
                    }
                    return View("Index",vm);
                }
                return View("Index",vm);
            }
        }
    }
}
