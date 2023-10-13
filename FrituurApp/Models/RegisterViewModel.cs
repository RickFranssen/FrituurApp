using System.ComponentModel.DataAnnotations;

namespace FrituurApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string? CustomerName { get; set; }
        [Required, EmailAddress]
        public string? CustomerEmail { get; set; }
        [Required]
        public string? CustomerPassword { get; set; }


    }
}
