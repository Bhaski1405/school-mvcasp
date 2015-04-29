using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AcademyApp.Entities
{
    public class academycontext:DbContext
    {
        public DbSet<Training> Trainings { get; set; }
    }
}