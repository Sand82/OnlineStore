using OnlineStore.Domain.Repositories.Models;

namespace OnlineStore.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IItemRepository ItemRepository { get; }

        ICategoryRepository CategoryRepository { get; }

        IMainCategoryRepository MainCategoryRepository { get; }

        Task<int> SaveChangesAsync();
    }
}
