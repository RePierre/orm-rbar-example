using RbarExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbarExample.Services
{
    public interface IOrderService
    {
        void PlaceOrder(Guid customerId, IEnumerable<OrderItem> orderItems);
    }
}
