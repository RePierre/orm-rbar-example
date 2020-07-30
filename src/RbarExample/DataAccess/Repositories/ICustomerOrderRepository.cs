using RbarExample.Entities;

namespace RbarExample.DataAccess.Repositories
{
    public interface ICustomerOrderRepository
    {
        void Register(CustomerOrder order);
    }
}
