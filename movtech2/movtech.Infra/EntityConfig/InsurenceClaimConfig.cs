using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    public class InsurenceClaimConfig : IEntityTypeConfiguration<InsurenceClaim>
    {
        public void Configure(EntityTypeBuilder<InsurenceClaim> builder)
        {

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.InsurenceClaimDate).IsRequired(true);
            builder.Property(p => p.InsurenceClaimNumber).IsRequired(true);
            builder.Property(p => p.OccurrenceNumber).IsRequired(true);
          
            builder.Property(p => p.Observation).IsRequired(false);

            builder.Property(p => p.InsurenceClaimType).IsRequired(true);

            builder.HasOne(p => p.Insurence);

            builder.HasOne(p => p.Driver);


            //Address
            builder.Property(p => p.CEP).IsRequired().HasMaxLength(9);
            builder.Property(p => p.Street).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Number).IsRequired();
            builder.Property(p => p.Neighborhood).IsRequired().HasMaxLength(100);
            builder.Property(p => p.City).IsRequired().HasMaxLength(100);
            builder.Property(p => p.UF).IsRequired();



        }
    }
}
