using System;
using System.ComponentModel.DataAnnotations;

namespace GoalsOsrs.Models
{
    public class SignInViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
