using RbarExample.DataAccess;
using RbarExample.DataAccess.Repositories;
using RbarExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RbarExample.Services
{
    public class BetterOrderService : IOrderService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IItemRepository _itemRepository;
        private readonly ICustomerOrderRepository _customerOrderRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BetterOrderService(ICustomerRepository customerRepository, IItemRepository itemRepository,
            ICustomerOrderRepository customerOrderRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _itemRepository = itemRepository;
            _customerOrderRepository = customerOrderRepository;
            _unitOfWork = unitOfWork;
        }

        public void PlaceOrder(Guid customerId, IEnumerable<OrderItem> orderItems)
        {
            var customer = _customerRepository.Get(customerId);
            var customerOrder = new CustomerOrder(customer);

            // Hack: There is an issue with EF Core not properly processing the join statement.
            var itemIds = orderItems.Select(i => i.ItemId).Distinct();
            var items = _itemRepository.Items
                .Where(i => itemIds.Contains(i.Id))
                //.Join(orderItems,
                //      item => item.Id,
                //      orderedItem => orderedItem.ItemId,
                //      (item, _) => item)
                .ToDictionary(i => i.Id);

            foreach (var orderedItem in orderItems)
            {
                var item = items[orderedItem.ItemId];
                item.DecreaseStockCount(orderedItem.Quantity);
		_itemRepository.Update(item);
                customerOrder.Add(orderedItem);
            }

            _customerOrderRepository.Register(customerOrder);
            _unitOfWork.Commit();
        }
    }
}
