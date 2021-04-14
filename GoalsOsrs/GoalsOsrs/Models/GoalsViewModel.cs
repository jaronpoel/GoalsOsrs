using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoalsOsrs.Models
{
    public class GoalsViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }
    }
}
