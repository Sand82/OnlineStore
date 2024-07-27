using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Models;

namespace OnlineStore.Data
{
    public class OnlineStoreDbContext : DbContext
    {
        public OnlineStoreDbContext()
        {}

        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options)
           : base(options)
        {}        

        public virtual DbSet<Item> Items { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(i => i.Price)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
