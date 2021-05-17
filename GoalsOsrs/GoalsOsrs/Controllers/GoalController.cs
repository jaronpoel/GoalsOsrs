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

        public IActionResult DeleteGoal(int id)
        {
            GoalCollection.DeleteGoal(id);
            return RedirectToAction("Goals", "Goal");
        }

        public IActionResult UpdateGoal(int id)
        {
            Goal goal = GoalCollection.GetByIDGoals(id);
            if (goal == null)
            {
                return RedirectToAction("Goals", "Goal");
            }
            ViewBag.Goal = goal;
            return View();
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

        [HttpPost]
        public IActionResult UpdateFullGoal(GoalViewModel goal)
        {
            //klopt nog niet voor kind en level. haal ik niet op en daarom zegt de app nu dat modelstate false is.
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                Goal updategoal = new Goal(goal.Title, goal.Level, goal.Description, goal.Kind);
                Goal.UpdateGoal(updategoal);
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
