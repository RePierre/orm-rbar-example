using RbarExample.Entities;
using System;
using System.Linq;

namespace RbarExample.DataAccess.Repositories
{
    class ItemRepository : IItemRepository
    {
        private readonly DataContext _dataContext;

        public ItemRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<Item> Items => _dataContext.Set<Item>();

        public Item Get(Guid itemId)
        {
            return Items.Single(i => i.Id == itemId);
        }

        public void Update(Item item)
        {
            _dataContext.Update(item);
        }
    }
}
