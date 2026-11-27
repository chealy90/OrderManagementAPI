using Microsoft.EntityFrameworkCore;
namespace OrderManagementAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;


        // post tag
        // order item
        //code referenced from: https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many#many-to-many-with-class-for-join-entity
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
            .HasMany(e => e.Items)
            .WithMany(e => e.Orders)
            .UsingEntity<OrderItem>();
        }
    }
}