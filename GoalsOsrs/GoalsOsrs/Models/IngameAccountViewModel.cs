using System;
using System.ComponentModel.DataAnnotations;

namespace GoalsOsrs.Models
{
    public class IngameAccountViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Type { get; set; }
    }
}
