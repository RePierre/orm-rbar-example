using RbarExample.Entities;

namespace RbarExample.DataAccess.Repositories
{
    internal class CustomerOrderRepository : ICustomerOrderRepository
    {
        private readonly DataContext _dataContext;

        public CustomerOrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Register(CustomerOrder order)
        {
            _dataContext.Add(order);
        }
    }
}
