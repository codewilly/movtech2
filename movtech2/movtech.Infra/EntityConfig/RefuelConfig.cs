using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    public class RefuelConfig : IEntityTypeConfiguration<Refuel>
    {
        public void Configure(EntityTypeBuilder<Refuel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.TotalValue).IsRequired();
            builder.Property(p => p.LiterValue).IsRequired();
            builder.Property(p => p.Liters).IsRequired();
            builder.Property(p => p.FuelType).IsRequired();
            builder.Property(p => p.RefuelDate).IsRequired();

        }
    }
}
