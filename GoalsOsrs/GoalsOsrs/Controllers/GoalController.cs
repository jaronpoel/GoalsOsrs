﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoalsOsrs.Models;

namespace GoalsOsrs.Controllers
{
    public class GoalController : Controller
    {
        public IActionResult Goal()
        {
            return View();
        }

        public IActionResult AddGoal()
        {
            return View();
        }
    }
}