using System;
using System.Collections.Generic;

namespace RbarExample.Entities
{
    public class CustomerOrder
    {
        public CustomerOrder()
        {
            Id = Guid.NewGuid();
            OrderDate = DateTime.UtcNow;
            Items = new List<OrderItem>();
        }

        public CustomerOrder(Customer customer) : this()
        {
            Customer = customer;
            CustomerId = customer.Id;
        }

        public Guid Id { get; set; }

        public Customer Customer { get; private set; }

        public Guid CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<OrderItem> Items { get; set; }

        public void Add(OrderItem orderedItem)
        {
            Items.Add(new OrderItem
            {
                ItemId = orderedItem.ItemId,
                OrderId = Id,
                Quantity = orderedItem.Quantity
            });
        }
    }
}
