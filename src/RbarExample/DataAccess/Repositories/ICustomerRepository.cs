using RbarExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbarExample.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(Guid customerId);
    }
}
