using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    public class MaintenanceConfig : IEntityTypeConfiguration<Maintenance>
    {
        public void Configure(EntityTypeBuilder<Maintenance> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.MaintenanceDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.Cost).HasColumnType("decimal(10, 2)");
            builder.Property(p => p.OperationDescription).HasMaxLength(1000);

        }
    }
}
