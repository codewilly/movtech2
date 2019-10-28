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
            modelBuilder.ApplyConfiguration(new DriverConfig());
            modelBuilder.ApplyConfiguration(new EntranceAndExitConfig());

        }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<EntranceAndExit> EntranceAndExits { get; set; }


    }
}
