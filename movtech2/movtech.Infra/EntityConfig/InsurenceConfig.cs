using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    class InsurenceConfig : IEntityTypeConfiguration<Insurence>
    {
        public void Configure(EntityTypeBuilder<Insurence> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.BeginOfVigency).IsRequired();
            builder.Property(p => p.EndOfVigency).IsRequired();
            builder.Property(p => p.CINumber).IsRequired();
            builder.Property(p => p.PolicyNumber).IsRequired();
            builder.Property(p => p.HasInsurenceClaim).HasColumnType("bit").HasDefaultValue(false);



            
            builder.HasOne(p => p.Broker);
            builder.HasOne(p => p.Insurer);
            builder.HasOne(p => p.Vehicle).WithOne(p => p.Insurence).HasForeignKey<Insurence>(p => p.VehicleId).IsRequired(true);
            

        }
    }
}
