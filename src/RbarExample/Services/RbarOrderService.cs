using RbarExample.DataAccess;
using RbarExample.DataAccess.Repositories;
using RbarExample.Entities;
using System;
using System.Collections.Generic;

namespace RbarExample.Services
{
    public class RbarOrderService : IOrderService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IItemRepository _itemRepository;
        private readonly ICustomerOrderRepository _customerOrderRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RbarOrderService(ICustomerRepository customerRepository, IItemRepository itemRepository,
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
            var order = new CustomerOrder(customer);

            foreach (var orderedItem in orderItems)
            {
                var item = _itemRepository.Get(orderedItem.ItemId);
                item.DecreaseStockCount(orderedItem.Quantity);
                _itemRepository.Update(item);
                order.Add(orderedItem);
            }

            _customerOrderRepository.Register(order);
            _unitOfWork.Commit();
        }
    }
}
