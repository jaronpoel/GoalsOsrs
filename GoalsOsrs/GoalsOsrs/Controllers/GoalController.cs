using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoalsOsrs.Models;
using Exceptions.Goal;
using Logic;

namespace GoalsOsrs.Controllers
{
    public class GoalController : Controller
    {
        private Goal Goal { get; } = new Goal();
        private GoalCollection GoalCollection { get; } = new GoalCollection();

        public IActionResult Goals()
        {
            AllGoalsViewModel ViewModel = new AllGoalsViewModel();
            ViewModel.ListOfGoals = GoalCollection.GetAllGoals();
            return View(ViewModel);
        }

        public IActionResult AddGoal()
        {
            return View();
        }

        public ActionResult DeleteGoal(int id)
        {
            GoalCollection.DeleteGoal(id);
            return RedirectToAction("Goals", "Goal");
        }

        public IActionResult SingleGoal(int id)
        {
            Goal goal = GoalCollection.GetByIDGoals(id);
            if (goal == null)
            {
                return RedirectToAction("Goals", "Goal");
            }
            ViewBag.Goal = goal;
            return View();
        }

        [HttpPost]
        public IActionResult AddGoalAdded(GoalViewModel goal)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                Goal newgoal = new Goal(goal.Title, goal.Level, goal.Description, goal.Kind);
                GoalCollection.AddGoal(newgoal);
                return RedirectToAction("Goals", "Goal");
            }
            catch (AddGoalFailedException exception)
            {
                ModelState.AddModelError("", exception.Message);
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
