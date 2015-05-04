﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademyApp.Entities;

namespace AcademyApp.Models
{
    public class TrainingIndex
    {
        public List<Training> Trainings { get; set; }
        public string SearchPhrase { get; set; }
    }
}