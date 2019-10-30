﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using movtech.Infra.Context;

namespace movtech.Infra.Migrations
{
    [DbContext(typeof(MovtechContext))]
    [Migration("20191029152434_refuel and gasstation")]
    partial class refuelandgasstation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("movtech.Domain.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("CNH")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("CNHCategory")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("Status");

                    b.Property<int?>("VehicleId");

                    b.HasKey("Id");

                    b.HasAlternateKey("CNH");


                    b.HasAlternateKey("CPF");

                    b.HasIndex("VehicleId")
                        .IsUnique();

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("movtech.Domain.Entities.EntranceAndExit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 10, 29, 12, 24, 34, 733, DateTimeKind.Local));

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<int>("DriverId");

                    b.Property<bool>("IsEntrance")
                        .HasColumnType("bit");

                    b.Property<int>("VehicleId");

                    b.Property<float>("VehicleKms");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("EntranceAndExits");
                });

            modelBuilder.Entity("movtech.Domain.Entities.GasStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasAlternateKey("CNPJ");

                    b.ToTable("GasStations");
                });

            modelBuilder.Entity("movtech.Domain.Entities.Refuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FuelType");

                    b.Property<int?>("GasStationId");

                    b.Property<int?>("GasStationId1");

                    b.Property<double>("LiterValue");

                    b.Property<float>("Liters");

                    b.Property<DateTime>("RefuelDate");

                    b.Property<double>("TotalValue");

                    b.Property<int?>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("GasStationId");

                    b.HasIndex("GasStationId1");

                    b.HasIndex("VehicleId");

                    b.ToTable("Refuels");
                });

            modelBuilder.Entity("movtech.Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("DriverId");

                    b.Property<int>("FuelType");

                    b.Property<bool>("InGarage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<float>("Quilometers");

                    b.Property<string>("Renavam")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<int>("Status");

                    b.Property<int>("VehicleType");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasAlternateKey("LicensePlate");


                    b.HasAlternateKey("Renavam");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("movtech.Domain.Entities.Driver", b =>
                {
                    b.HasOne("movtech.Domain.Entities.Vehicle", "Vehicle")
                        .WithOne("Driver")
                        .HasForeignKey("movtech.Domain.Entities.Driver", "VehicleId");
                });

            modelBuilder.Entity("movtech.Domain.Entities.EntranceAndExit", b =>
                {
                    b.HasOne("movtech.Domain.Entities.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("movtech.Domain.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("movtech.Domain.Entities.Refuel", b =>
                {
                    b.HasOne("movtech.Domain.Entities.GasStation", "GasStation")
                        .WithMany()
                        .HasForeignKey("GasStationId");

                    b.HasOne("movtech.Domain.Entities.GasStation")
                        .WithMany("Refuels")
                        .HasForeignKey("GasStationId1");

                    b.HasOne("movtech.Domain.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");
                });
#pragma warning restore 612, 618
        }
    }
}