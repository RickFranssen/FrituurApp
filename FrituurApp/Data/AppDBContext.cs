using FrituurApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FrituurApp.Data
{
    public class AppDBContext : IdentityDbContext<Customer>
    {
        public DbSet<Customer> Customer { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> contextOptions) : base(contextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<FrituurApp.Models.Order>? Order { get; set; }

        public DbSet<FrituurApp.Models.Administrator>? Administrator { get; set; }

        public DbSet<FrituurApp.Models.OrderLine>? OrderLine { get; set; }

        public DbSet<FrituurApp.Models.Product>? Product { get; set; }
    }
}
