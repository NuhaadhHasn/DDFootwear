using DDFootwear.API.Model;
using Microsoft.EntityFrameworkCore;

namespace DDFootwear.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.CostPrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().Property(p => p.RetailPrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().Property(p => p.WholeSalePrice).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Sale>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data Source=NUHAADH-LAPTOP;Database=DDFootwear;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
