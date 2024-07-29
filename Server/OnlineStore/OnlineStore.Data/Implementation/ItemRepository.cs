using OnlineStore.Data.Implementation.Main;
using OnlineStore.Domain.Models;
using OnlineStore.Domain.Repositories.Models;

namespace OnlineStore.Data.Implementation
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        public ItemRepository(OnlineStoreDbContext context)
            :base(context)
        {}        
    }
}
