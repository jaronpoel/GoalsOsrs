using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
