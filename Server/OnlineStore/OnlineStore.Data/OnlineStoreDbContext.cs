using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Models;

namespace OnlineStore.Data
{
    public class OnlineStoreDbContext : IdentityDbContext
    {
        public OnlineStoreDbContext()
        {}

        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options)
           : base(options)
        {}        

        public virtual DbSet<Item> Items { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<MainCategory> MainCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(i => i.Price)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
