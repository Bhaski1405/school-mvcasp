﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademyApp.Models;

namespace AcademyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            
            return View("Index");
        }

        public ActionResult About() {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Demo(int id =0)
        {
            return View("Index");
        }
    }
}
