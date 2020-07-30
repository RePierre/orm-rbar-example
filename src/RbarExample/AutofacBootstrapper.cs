using Autofac;
using RbarExample.DataAccess;
using RbarExample.DataAccess.Repositories;
using RbarExample.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbarExample
{
    class AutofacBootstrapper
    {
        public static IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DataContext>().SingleInstance();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<CustomerOrderRepository>().As<ICustomerOrderRepository>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<ItemRepository>().As<IItemRepository>();

            builder.RegisterType<RbarOrderService>().Named<IOrderService>("RBAR");
            builder.RegisterType<BetterOrderService>().Named<IOrderService>("Better");

            return builder.Build();
        }
    }
}
