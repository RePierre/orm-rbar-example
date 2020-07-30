using Autofac;
using Microsoft.EntityFrameworkCore;
using RbarExample.DataAccess;
using RbarExample.DataAccess.Repositories;
using RbarExample.Entities;
using RbarExample.Services;
using System;
using System.Linq;

namespace RbarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var container = AutofacBootstrapper.Bootstrap())
            {
                var itemsRepo = container.Resolve<IItemRepository>();

                var hugeOrder = itemsRepo.Items.Take(1000).Select(i => new OrderItem { ItemId = i.Id, Quantity = 10 }).ToArray();

                //var service = container.ResolveNamed<IOrderService>("RBAR");
                var service = container.ResolveNamed<IOrderService>("Better");
                service.PlaceOrder(Guid.Parse("8D2FB311-18F8-4851-B3C8-EE0BF668426C"), hugeOrder);
            }
        }
    }
}
