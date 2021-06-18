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
        public string ValueOfKind { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [DataType(DataType.Text)]
        public int AccountId { get; set; }

        [DataType(DataType.Text)]
        public string Status { get; set; }

        [DataType(DataType.Text)]
        public int Id { get; set; }
    }
}
