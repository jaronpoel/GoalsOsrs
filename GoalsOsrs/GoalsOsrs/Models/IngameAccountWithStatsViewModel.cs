using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoalsOsrs.Models
{
    public class IngameAccountWithStatsViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Type { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public List<Stat> stats { get; set; }
    }
}
