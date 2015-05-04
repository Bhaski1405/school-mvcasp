using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademyApp.Entities;
using AcademyApp.Models;

namespace AcademyApp.Controllers
{
    public class TrainingsController : Controller
    {
        //difference between httpput and httppost
        //httpput - idempotent .. 
        //httpost  - not idempotent .. 
        [HttpGet]
        public ActionResult Add() { 
            //this is the method that throws the form to add the training
            Training vm = new Training();

            return View("Add", vm);
        }
        [HttpPost]
        public ActionResult Add(Training t) {
            TrainingIndex vm = new TrainingIndex() { };
            using (academycontext db  = new academycontext())
            {
                db.Trainings.Add(t);
                db.SaveChanges();
                vm.Trainings = db.Trainings.Select(x => x).ToList<Training>();
            }
            return View("Index", vm);
        }
        public ActionResult Index(int top=5, int skip=0)
        {
            TrainingIndex vm = new TrainingIndex() {};
            using (academycontext db = new academycontext())
            {
                var result = db.Trainings.OrderBy(x => x.Id).Skip(skip).Take(top);
                vm.Trainings = result.ToList<Training>();

            }
            return View("Index", vm);
        }
        public ActionResult Search(string SearchPhrase)
        {
            TrainingIndex vm = new TrainingIndex() {};
            using (academycontext db = new academycontext())
            {
                var result = db.Trainings.Where(x => x.Title.ToLower().Contains(SearchPhrase.ToLower())).Select(x=>x);

                vm.Trainings = result.ToList<Training>();

            }
            return View("Index", vm);
        }

    }
}
