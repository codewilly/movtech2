using Microsoft.EntityFrameworkCore;
using movtech.Domain.Entities;
using movtech.Infra.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.Context
{
    public class MovtechContext : DbContext
    {
        public MovtechContext(DbContextOptions<MovtechContext> opt) : base(opt)
        {
        }

        // Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set Specific models Configurations
            modelBuilder.ApplyConfiguration(new VehicleConfig());
            modelBuilder.ApplyConfiguration(new VehicleModelConfig());

        }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehicleModel> VehicleModels { get; set; }

    }
}
