using Microsoft.AspNetCore.Identity;

namespace FrituurApp.Models
{
    public class Customer:IdentityUser
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        
    }
}
