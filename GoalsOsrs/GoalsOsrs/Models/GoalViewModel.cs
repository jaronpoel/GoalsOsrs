using System;
using System.ComponentModel.DataAnnotations;

namespace GoalsOsrs.Models
{
    public class GoalViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Kind { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Level { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }

    }
}
