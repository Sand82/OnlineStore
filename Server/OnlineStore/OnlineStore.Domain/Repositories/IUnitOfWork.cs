using OnlineStore.Domain.Repositories.Models;

namespace OnlineStore.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IItemRepository Item { get; }

        ICategoryRepository Category { get; }

        IMainCategoryRepository MainCategory { get; }

        Task<int> SaveChangesAsync();        
    }
}
