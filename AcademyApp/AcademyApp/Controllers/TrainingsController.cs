using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademyApp.Models;
using AcademyApp.Entities;

namespace AcademyApp.Controllers
{
    public class TrainingsController : Controller
    {
        public ActionResult Index(int top = 5, int skip= 0)
        {
            TrainingIndex vm = new TrainingIndex();

            using (academycontext db = new academycontext())
            {
                var result = db.Trainings.OrderBy(x => x.Id).Skip(skip).Take(top);
                 vm .Trainings = result.ToList<Training>();
            }
            return View("Index", vm);
        }

        public ActionResult Search(string titleLike="")
        {
            TrainingIndex vm = new TrainingIndex();
            using (academycontext db = new academycontext())
            {
                var result = db.Trainings.Where(x => x.Title.ToLower().Contains(titleLike)).Select(x => x);
                vm.Trainings = result.ToList<Training>();
            }

            return View("Index", vm);
        }
    }
}
