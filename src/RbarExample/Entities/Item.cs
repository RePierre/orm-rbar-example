using System;
using System.Collections.Generic;
using System.Text;

namespace RbarExample.Entities
{
    public class Item
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public int StockCount { get; private set; }

        public void DecreaseStockCount(int quantity)
        {
            if (StockCount-quantity<0)
            {
                throw new ArgumentException("Quantity exceeds stock count.");
            }

            StockCount -= quantity;
        }
    }
}
