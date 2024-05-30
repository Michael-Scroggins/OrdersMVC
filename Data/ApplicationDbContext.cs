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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite primary key
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId });

            // Configure relationships
            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(op => op.ProductId);
        }
    }
}