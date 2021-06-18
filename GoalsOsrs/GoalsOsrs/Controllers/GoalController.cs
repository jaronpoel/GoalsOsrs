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
<<<<<<< HEAD
using Logic.Interfaces;
using FactoryLogic;

=======
using Logic.Interfaces;
using FactoryLogic;

>>>>>>> main
namespace GoalsOsrs.Controllers
{
    public class GoalController : Controller
    {
        private IGoal Goal { get; } = FactoryLogicLayer.CreateGoal();
        private IGoalCollection GoalCollection { get; } = FactoryLogicLayer.CreateGoalCollection();

        public IActionResult Goals(int AccId)
        {
            AllGoalsViewModel ViewModel = new AllGoalsViewModel();
            ViewModel.ListOfGoals = GoalCollection.GetAllGoalsByIngameAccount(AccId);
<<<<<<< HEAD
            ViewBag.AccountId = AccId;
=======
>>>>>>> main
            return View(ViewModel);
        }

        public IActionResult AddGoal(int AccId)
        {
            ViewBag.AccountId = AccId;
            return View();
        }

        public IActionResult DeleteGoal(int id)
        {
            GoalCollection.DeleteGoal(id);
            return RedirectToAction("Goals", "Goal");
        }

        public IActionResult UpdateGoal(int id)
        {
            IGoal goal = GoalCollection.GetByIDGoals(id);
            if (goal == null)
            {
                return RedirectToAction("Goals", "Goal");
            }
            ViewBag.Goal = goal;
            return View();
        }

        public IActionResult SingleGoal(int id)
        {
            IGoal goal = GoalCollection.GetByIDGoals(id);
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
                Goal newgoal = new Goal(goal.Title, goal.Kind, goal.ValueOfKind, goal.Description, goal.AccountId);
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
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                Goal updategoal = new Goal(goal.Id, goal.Title, goal.Kind, goal.ValueOfKind, goal.Description, goal.Status);
                Goal.UpdateGoal(updategoal);
                return RedirectToAction("Goals", "Goal");
            }
            catch (UpdateGoalFailedException exception)
            {
                ModelState.AddModelError("", exception.Message);
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
