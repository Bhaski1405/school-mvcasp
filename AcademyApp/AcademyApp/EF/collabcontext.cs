using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AcademyApp.EF
{
    public class collabcontext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}