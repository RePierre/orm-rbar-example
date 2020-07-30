using RbarExample.Entities;
using System;
using System.Linq;

namespace RbarExample.DataAccess.Repositories
{
    public interface IItemRepository
    {
        Item Get(Guid itemId);

        IQueryable<Item> Items { get; }

        void Update(Item item);
    }
}
