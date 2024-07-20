using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Models;

namespace OnlineStore.Data
{
    public class OnlineStoreDbContext : DbContext
    {
        public OnlineStoreDbContext()
        {
            
        }

        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options)
           : base(options)
        {}

        public virtual DbSet<Test> Tests { get; set; }
    }
}
