﻿using System.ComponentModel.DataAnnotations;
using System.Net;

namespace FrituurApp.Models
{
    public class LoginViewModel
    {
        [Required, EmailAddress]
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}
