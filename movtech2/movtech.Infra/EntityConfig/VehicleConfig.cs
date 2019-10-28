using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    public class VehicleConfig : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.LicensePlate).IsRequired().HasMaxLength(8);
            builder.HasAlternateKey(p => p.LicensePlate);
            builder.HasAlternateKey(p => p.Renavam);
            builder.Property(p => p.Renavam).HasMaxLength(11).IsRequired();
            builder.Property(p => p.Brand).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Model).HasMaxLength(256).IsRequired();
            builder.Property(p => p.InGarage).HasColumnType("bit").HasDefaultValue(true);
        }
    }
}
