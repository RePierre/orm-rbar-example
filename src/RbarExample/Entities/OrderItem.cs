using System;
using System.Collections.Generic;
using System.Text;

namespace RbarExample.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public Guid ItemId { get; set; }

        public int Quantity { get; set; }

        public CustomerOrder Order { get; set; }
    }
}
