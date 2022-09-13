using Microsoft.EntityFrameworkCore;
using WebApplication2.Migrations;

namespace WebApplication2.model
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;//=> Set<Order>();
        public DbSet<Customer> Customers { get; set; } = null!;// => Set<Customer>();
        public DbSet<Order_SKU> Order_SKUs { get; set; } = null!; //=> Set<Order_SKU>();
        public DbSet<SKU> SKUs { get; set; } = null!; //=> Set<SKU>();
        public DbSet<SKU_Category> SKU_Categories { get; set; } = null!; //=> Set<SKU_Category>();

        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ordersdb;Username=postgres;Password=qwe123");
        }
    }
}
