using Logic;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoalsOsrs.Models
{
    public class AllIngameAccountsViewModel
    {
        public List<IIngameAccount> ListOfIngameAccounts { get; set; }
    }
}
