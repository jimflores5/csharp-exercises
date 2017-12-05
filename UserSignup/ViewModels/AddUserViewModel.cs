using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage="Please enter a username.")]
        public string Username { get; set; }

        [EmailAddress(ErrorMessage = "Invalid e-mail address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [MinLength(6, ErrorMessage = "Password must be 6 - 10 characters long.")]
        [StringLength(10, ErrorMessage = "Password must be 6 - 10 characters long.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Verify password")]
        [Required(ErrorMessage = "Please verify your password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string Verify { get; set; }


    }
}
