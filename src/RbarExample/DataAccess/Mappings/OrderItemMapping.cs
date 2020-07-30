using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbarExample.Entities;

namespace RbarExample.DataAccess.Mappings
{
    class OrderItemMapping : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems")
                .HasKey(_ => _.Id);
        }
    }
}
