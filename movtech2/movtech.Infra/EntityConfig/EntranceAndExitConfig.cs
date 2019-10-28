using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.EntityConfig
{
    class EntranceAndExitConfig : IEntityTypeConfiguration<EntranceAndExit>
    {
        public void Configure(EntityTypeBuilder<EntranceAndExit> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Description).HasMaxLength(255);
            builder.Property(p => p.CreationDate).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(p => p.IsEntrance).HasColumnType("bit");
            builder.HasOne(p => p.Vehicle);
            builder.HasOne(p => p.Driver);
        }
    }
}
