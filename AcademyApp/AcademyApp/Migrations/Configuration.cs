namespace AcademyApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AcademyApp.EF;

    internal sealed class Configuration : DbMigrationsConfiguration<AcademyApp.EF.collabcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AcademyApp.EF.collabcontext context)
        {
            Employee[] employees = new Employee[] { 
                new Employee(){Alias="Employee1", Email="employee_1@abc.com", Id=1},
                new Employee(){Alias="Employee2", Email="employee_2@abc.com", Id=2},
                new Employee(){Alias="Employee3", Email="employee_3@abc.com", Id=3},
                new Employee(){Alias="Employee4", Email="employee_4@abc.com", Id=4},

            };
            Array.ForEach<Employee>(
                       array: employees.ToArray<Employee>(),
                       action: e=> context.Employees.Add(e)
                       );
            context.SaveChanges();
        }
    }
}
