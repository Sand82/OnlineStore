using OnlineStore.Data.Implementation.Main;
using OnlineStore.Domain.Models;
using OnlineStore.Domain.Repositories.Models;

namespace OnlineStore.Data.Implementation
{
    public class MainCategoryRepository : GenericRepository<MainCategory>, IMainCategoryRepository
    {
        public MainCategoryRepository(OnlineStoreDbContext context) 
            : base(context)
        {}
    }
}
