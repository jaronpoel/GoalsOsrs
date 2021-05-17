using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exceptions.IngameAccount;
using GoalsOsrs.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;

namespace GoalsOsrs.Controllers
{
    public class IngameAccountController : Controller
    {
        private IngameAccount ingameAccount { get; } = new IngameAccount();
        private IngameAccountCollection ingameAccountCollection { get; } = new IngameAccountCollection();

        public IActionResult IngameAccounts()
        {
            AllIngameAccountsViewModel ViewModel = new AllIngameAccountsViewModel();
            ViewModel.ListOfIngameAccounts = ingameAccountCollection.GetAllIngameAccounts();
            return View(ViewModel);
        }

        public IActionResult AddIngameAccount()
        {
            return View();
        }

        public IActionResult SingleIngameAccount(int id)
        {
            IngameAccount account = ingameAccountCollection.GetIngameAccountByID(id);
            if (account == null)
            {
                return RedirectToAction("IngameAccounts", "IngameAccount");
            }
            ViewBag.Account = account;
            return View();
        }

        [HttpPost]
        public IActionResult AddIngameAccountAdded(IngameAccountViewModel account)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                IngameAccount newaccount = new IngameAccount(account.Name, account.Type);
                ingameAccountCollection.AddIngameAccount(newaccount);
                return RedirectToAction("IngameAccounts", "IngameAccount");
            }
            catch (AddIngameAccountFailedException exception)
            {
                ModelState.AddModelError("", exception.Message);
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
