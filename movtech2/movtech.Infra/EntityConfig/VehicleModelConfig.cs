﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    class VehicleModelConfig : IEntityTypeConfiguration<VehicleModel>
    {
        public void Configure(EntityTypeBuilder<VehicleModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
        }
    }
}
