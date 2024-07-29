using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

using OnlineStore.Domain.Repositories;

namespace OnlineStore.Data.Implementation.Main
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly OnlineStoreDbContext context;

        public GenericRepository(OnlineStoreDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await context.Set<T>().AddRangeAsync(entities);
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            var result = await context.Set<T>()
                .Where(predicate)
                .ToListAsync();

            return result;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await context.Set<T>()
                .ToListAsync();

            return result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);

            return entity;
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }
    }
}
