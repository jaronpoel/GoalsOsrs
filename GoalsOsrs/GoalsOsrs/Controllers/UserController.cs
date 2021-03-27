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

namespace GoalsOsrs.Controllers
{
    public class UserController : Controller
    {
        private UserCollection UserCollection { get; } = new UserCollection();
        private User User { get; } = new User();
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
                User auth = User.SignIn(user.Email, user.Password);
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
