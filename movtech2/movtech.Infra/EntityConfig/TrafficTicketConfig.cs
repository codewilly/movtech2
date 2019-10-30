using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    public class TrafficTicketConfig : IEntityTypeConfiguration<TrafficTicket>
    {
        public void Configure(EntityTypeBuilder<TrafficTicket> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.WasPaid).HasColumnType("bit").HasDefaultValue(false);
            builder.Property(p => p.Description).HasMaxLength(255);
            builder.Property(p => p.CEP).HasMaxLength(9);
            builder.Property(p => p.Street).HasMaxLength(100);
            builder.Property(p => p.Neighborhood).HasMaxLength(100);
            builder.Property(p => p.City).HasMaxLength(100);
            builder.Property(p => p.TrafficTicketDate).IsRequired();
            builder.Property(p => p.BilletExpiration).IsRequired();
            builder.Property(p => p.Cost).IsRequired().HasColumnType("decimal(10, 2)");
            builder.Property(p => p.Points).IsRequired();
            builder.Property(p => p.Level).IsRequired();

        }
    }
}


