using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbarExample.Entities;

namespace RbarExample.DataAccess.Mappings
{
    class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items")
                .HasKey(_ => _.Id);
        }
    }
}
