﻿using System.ComponentModel.DataAnnotations;

namespace Admin_Service.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required,DataType(DataType.Password), Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name ="Remember me")]
       public bool RememberMe { get; set; }
    }
}
