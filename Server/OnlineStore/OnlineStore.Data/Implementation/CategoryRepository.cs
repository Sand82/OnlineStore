using OnlineStore.Data.Implementation.Main;
using OnlineStore.Domain.Models;
using OnlineStore.Domain.Repositories.Models;

namespace OnlineStore.Data.Implementation
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(OnlineStoreDbContext context) 
            : base(context)
        {}
    }
}
