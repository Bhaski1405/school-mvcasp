using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcademyApp.Entities {
    public class academycontext :DbContext{
        public DbSet<Employee> Employees { get; set; }
    }
}