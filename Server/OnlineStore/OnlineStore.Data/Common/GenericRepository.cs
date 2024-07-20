using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Data.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private OnlineStoreDbContext? dbContext = null;

        private DbSet<T>? table = null;

        public GenericRepository()
        {
            dbContext = new OnlineStoreDbContext();
            table = dbContext.Set<T>();
        }

        public GenericRepository(OnlineStoreDbContext context)
        {
            dbContext = context;
            table = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await table!.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            T? record = await table!.FindAsync(id);

            return record!;
        }

        public async Task AddAsync(T entity)
        {
            await table!.AddAsync(entity);
        }

        public void Update(T entity)
        {
            table!.Attach(entity);

            dbContext!.Entry(entity).State = EntityState.Modified;
        }
        
        public async Task DeleteAsync(int id)
        {
            T? existing = await table!.FindAsync(id);
            
            if (existing != null) 
            {
                table.Remove(existing);
            }            
        }
        
        public async Task<int> SaveAsync()
        {
            return await dbContext!.SaveChangesAsync();
        }        
    }
}
