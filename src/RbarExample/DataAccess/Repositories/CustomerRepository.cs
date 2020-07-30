using RbarExample.Entities;
using System;
using System.Linq;

namespace RbarExample.DataAccess.Repositories
{
    class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dataContext;

        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Customer Get(Guid customerId)
        {
            return _dataContext.Set<Customer>().Single(c => c.Id == customerId);
        }
    }
}
