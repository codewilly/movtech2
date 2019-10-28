using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    public class DriverConfig : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(150);
            builder.Property(p => p.CPF).IsRequired().HasMaxLength(14);
            builder.HasAlternateKey(p => p.CPF);

            builder.Property(p => p.Phone).IsRequired().HasMaxLength(15);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Address).IsRequired().HasMaxLength(255);
            builder.Property(p => p.CNH).IsRequired().HasMaxLength(11);
            builder.HasAlternateKey(p => p.CNH);
            builder.Property(p => p.CNHCategory).IsRequired().HasMaxLength(4);

            builder.HasOne(p => p.Vehicle).WithOne(p => p.Driver).HasForeignKey<Driver>(p => p.VehicleId).IsRequired(false);
        }
    }
}
