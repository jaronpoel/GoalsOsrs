using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoalsOsrs.Models;
using Microsoft.AspNetCore.Http;
using Logic;
using Exceptions.User;
using Logic.Interfaces;
using Dal.Context;
using FactoryLogic;

namespace GoalsOsrs.Controllers
{
    public class UserController : Controller
    {
        private IUser User { get; } = FactoryLogicLayer.CreateUser();
        private IUserCollection UserCollection { get; } = FactoryLogicLayer.CreateUserCollection();
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult Info(int id)
        {
            IUser user = UserCollection.GetUserByID(id);
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.User = user;
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignIn(SignInViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            IUser auth = UserCollection.SignIn(user.Email, user.Password); 

            if (auth == null)
            {
                ModelState.AddModelError("", "Something went wrong try it again");
                return View();
            }

            HttpContext.Session.SetInt32("userid", auth.Id);
            HttpContext.Session.SetString("name", auth.Name);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            HttpContext.Session.SetString("name", string.Empty);
            HttpContext.Session.SetInt32("userid", 0);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(SignUpViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            IUser madeUser = UserCollection.SignUp(user.Email, user.Password, user.Name);

            if (madeUser == null)
            {
                ModelState.AddModelError("", "Email is already in use try another one");
                return View();
            }
            return RedirectToAction("SignIn", "User");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateFullUser(SignUpViewModel user, int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            IUser madeUser = User.UpdateUser(id, user.Name, user.Password, user.Email);

            if (madeUser == null)
            {
                ModelState.AddModelError("", "Something went wrong try it again");
                return RedirectToAction("Info", "User", id);
            }

            HttpContext.Session.SetString("name", madeUser.Name);
            return RedirectToAction("Index", "Home");
        }
    }
}
