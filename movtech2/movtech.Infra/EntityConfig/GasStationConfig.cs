﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    public class GasStationConfig : IEntityTypeConfiguration<GasStation>
    {
        public void Configure(EntityTypeBuilder<GasStation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(150);
            builder.Property(p => p.CNPJ).IsRequired().HasMaxLength(18);
            builder.HasAlternateKey(p => p.CNPJ);

            //Address
            builder.Property(p => p.CEP).IsRequired().HasMaxLength(9);
            builder.Property(p => p.Street).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Number).IsRequired();
            builder.Property(p => p.Neighborhood).IsRequired().HasMaxLength(100);
            builder.Property(p => p.City).IsRequired().HasMaxLength(100); ;
            builder.Property(p => p.UF).IsRequired();

        }
    }
}