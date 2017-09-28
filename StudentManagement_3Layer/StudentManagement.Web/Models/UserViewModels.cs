using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagement.Web.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Avatar")]
        public string Image { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}