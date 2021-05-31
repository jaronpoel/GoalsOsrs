using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;

namespace DIprobeersel.Controllers
{
    public class EmployeeController : Controller
    {
        //DI voor logic
        private readonly IEmployee Empolye;
        public EmployeeController(IEmployee empolye)
        {
            Empolye = empolye;
        }

        //Methodes kunnen aanroepen met Empolye.methode(). En ook alleen maar die in de Interface IEmploye staat.
        public IActionResult Index()
        {
            return View();
        }
    }
}
