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
        private IUserCollection UserCollection { get; } = FactoryLogicLayer.CreateUserCollection();
        private IUser User { get; } = FactoryLogicLayer.CreateUser();
        public ActionResult SignIn()
        {
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

            try
            {
                IUser auth = User.SignIn(user.Email, user.Password);
                HttpContext.Session.SetInt32("userid", auth.Id);
                HttpContext.Session.SetString("name", auth.Name);
                return RedirectToAction("Index", "Home");
            }
            catch (AuthenticationFailedException ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            HttpContext.Session.SetString("name", string.Empty);
            HttpContext.Session.SetInt32("userid", 0);
            return RedirectToAction("Index", "Home");
        }
    }
}
