using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Warehouse
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=21715;Database=Warehouse;Username=postgres;Password=Postgres");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.Manufacturer);
                entity.Property(e => e.IsPerishable);
                entity.Property(e => e.ExpirationDate);
                entity.Property(e => e.SizeProduct);

            });
        }
    }

}
