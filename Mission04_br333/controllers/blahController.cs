﻿using Microsoft.AspNetCore.Mvc;
using Mission04_br333.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//This includes all of the controllers and the actions for the grade calculator
namespace Mission04_br333.controllers
{
    public class blahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalculator(GradeCalculatorModel model)
        {
            return View();
        }
    }
}
