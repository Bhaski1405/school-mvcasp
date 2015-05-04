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
            Training[] training = new Training[] {
                new Training(){ Anchor="niranjan", Description="this is for the CAD beginners", Duration=24f,Title="Basics of CATIAv5"},
                new Training(){ Anchor="niranjan", Description="this is the basic course for the KBE engineers", Duration=24f,Title="CATIAv5 VBA"},
                new Training(){ Anchor="niranjan", Description="this is the basic course for web application development", Duration=24f,Title="MVC4 ASP webapplications development jumpstart"},
                new Training(){ Anchor="niranjan", Description="this is the basic course for C# programmers", Duration=24f,Title="C# Jumpstart"},
                new Training(){ Anchor="niranjan", Description="this is the basic course for language integrated query", Duration=24f,Title="LINQ jumpstart"},
                new Training(){ Anchor="niranjan", Description="this is the basic course for VB.NET developers", Duration=24f,Title="VB.NET jumpstart"},
                

            };
            Array.ForEach(training, x => context.Trainings.AddOrUpdate(x));
        }
    }
}
