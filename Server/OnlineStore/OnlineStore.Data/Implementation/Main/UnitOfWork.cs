using OnlineStore.Domain.Repositories;
using OnlineStore.Domain.Repositories.Models;

namespace OnlineStore.Data.Implementation.Main
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineStoreDbContext context;

        public UnitOfWork(OnlineStoreDbContext context)
        {
            this.context = context;

            Item = new ItemRepository(context);
            Category = new CategoryRepository(context);
            MainCategory = new MainCategoryRepository(context);
        }

        public IItemRepository Item { get; private set; }

        public ICategoryRepository Category { get; private set; }

        public IMainCategoryRepository MainCategory { get; private set; }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }        

        public async void Dispose()
        {
           await context.DisposeAsync();
        }
    }
}
