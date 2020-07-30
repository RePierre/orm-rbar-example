using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbarExample.Entities;

namespace RbarExample.DataAccess.Mappings
{
    class CustomerOrderMapping : IEntityTypeConfiguration<CustomerOrder>
    {
        public void Configure(EntityTypeBuilder<CustomerOrder> builder)
        {
            builder.ToTable("CustomerOrders")
                .HasKey(_ => _.Id);

            builder.HasOne<Customer>(_ => _.Customer);
            builder.HasMany<OrderItem>(_ => _.Items)
                .WithOne(_ => _.Order);
        }
    }
}
