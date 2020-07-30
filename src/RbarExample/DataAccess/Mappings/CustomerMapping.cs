using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbarExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbarExample.DataAccess.Mappings
{
    class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers")
                .HasKey(_ => _.Id);
        }
    }
}
