namespace AcademyApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AcademyApp.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<AcademyApp.Entities.academycontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AcademyApp.Entities.academycontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            Employee[] employees = new Employee[] { 
                new Employee(){Alias="Employee1", Email="employee1@abc.com", Id=1},
                new Employee(){Alias="Employee2", Email="employee2@abc.com", Id=2},
                new Employee(){Alias="Employee3", Email="employee3@abc.com", Id=3},
                new Employee(){Alias="Employee4", Email="employee4@abc.com", Id=4},
            };
            Array.ForEach(employees, x => context.Employees.AddOrUpdate(x));
            context.SaveChanges();
        }
    }
}
