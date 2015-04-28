using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademyApp.Models;

namespace AcademyApp.Controllers
{
    public class TrainingsController : Controller
    {
        //
        // GET: /Trainings/
        Training[] trainings = new Training[] {
                new Training(){Anchor="niranjan", Description="starting web applications", Duration=24.00, Id=1, Title="MVC4 Web appliaction development"},
                new Training(){Anchor="niranjan", Description="learning to access data smartly", Duration=24.00, Id=2, Title="LINQ with EF 6.0"},
                new Training(){Anchor="niranjan", Description="CAD tools", Duration=24.00, Id=1, Title="CATIA v5"},
                new Training(){Anchor="niranjan", Description="CAD tools automcation", Duration=24.00, Id=1, Title="CATIAv5 VBA"},
                new Training(){Anchor="niranjan", Description="VB programming for the newbies", Duration=24.00, Id=1, Title="VB.NET Jumpstart"},
                new Training(){Anchor="niranjan", Description="Metaprograming and expressions", Duration=24.00, Id=1, Title="C# deep dive"},
            };
        public ActionResult Index()
        {
            
            return View("Index", new TrainingIndex() { Trainings= trainings.ToList<Training>()});
        }

        public ActionResult Search(string titleLike="")
        {
            
            var matchingRecords = trainings
                .Where(x => x.Title.ToLower().Contains(titleLike))
                .Select(x => x);

            return View("Index", new TrainingIndex() { Trainings=matchingRecords.ToList<Training>()});
        }
    }
}
