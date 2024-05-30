using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LogisticsMVC.Models;

namespace LogisticsMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LogisticsMVC.Models.Product> Product { get; set; }
        public DbSet<LogisticsMVC.Models.Order> Order { get; set; }

        public DbSet<LogisticsMVC.Models.OrderProduct> OrderProducts { get; set; }
    }
}