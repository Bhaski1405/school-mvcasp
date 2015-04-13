using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademyApp.EF;
namespace AcademyApp.Models
{
    public class EmployeeModel
    {
        public List<Employee> Result{ get; set; }
        public string SearchPhrase { get; set; }
    }
}