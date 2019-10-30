using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movtech.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GasStations",
                columns: table => new
                {
                    CEP = table.Column<string>(maxLength: 9, nullable: false),
                    Street = table.Column<string>(maxLength: 100, nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Neighborhood = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    UF = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<string>(maxLength: 18, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasStations", x => x.Id);
                    table.UniqueConstraint("AK_GasStations_CNPJ", x => x.CNPJ);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(maxLength: 100, nullable: false),
                    Model = table.Column<string>(maxLength: 256, nullable: false),
                    LicensePlate = table.Column<string>(maxLength: 8, nullable: false),
                    Renavam = table.Column<string>(maxLength: 11, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Quilometers = table.Column<float>(nullable: false),
                    FuelType = table.Column<int>(nullable: false),
                    VehicleType = table.Column<int>(nullable: false),
                    InGarage = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Status = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: true),
                    LastMaintenanceDate = table.Column<DateTime>(nullable: false),
                    LastMaintenanceKms = table.Column<float>(nullable: false),
                    LastTireChangeKms = table.Column<float>(nullable: false),
                    LastOilChangeKms = table.Column<float>(nullable: false),
                    NeedsMaintenance = table.Column<bool>(nullable: false),
                    NeedsChangeTires = table.Column<bool>(nullable: false),
                    NeedsChangeOil = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.UniqueConstraint("AK_Vehicles_LicensePlate", x => x.LicensePlate);
                    table.UniqueConstraint("AK_Vehicles_Renavam", x => x.Renavam);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    CEP = table.Column<string>(maxLength: 9, nullable: false),
                    Street = table.Column<string>(maxLength: 100, nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Neighborhood = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    UF = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    CPF = table.Column<string>(maxLength: 14, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    CNH = table.Column<string>(maxLength: 11, nullable: false),
                    CNHCategory = table.Column<string>(maxLength: 4, nullable: false),
                    VehicleId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.UniqueConstraint("AK_Drivers_CNH", x => x.CNH);
                    table.UniqueConstraint("AK_Drivers_CPF", x => x.CPF);
                    table.ForeignKey(
                        name: "FK_Drivers_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaintenanceDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 10, 30, 11, 29, 10, 752, DateTimeKind.Local)),
                    MaintenanceType = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    PreventivaOrCorretiva = table.Column<bool>(nullable: false),
                    TiresChanged = table.Column<bool>(nullable: false),
                    OilChanged = table.Column<bool>(nullable: false),
                    OperationDescription = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maintenances_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntranceAndExits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 10, 30, 11, 29, 10, 740, DateTimeKind.Local)),
                    VehicleId = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: false),
                    VehicleKms = table.Column<float>(nullable: false),
                    IsEntrance = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntranceAndExits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntranceAndExits_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntranceAndExits_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refuels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalValue = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    LiterValue = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Liters = table.Column<float>(nullable: false),
                    FuelType = table.Column<int>(nullable: false),
                    RefuelDate = table.Column<DateTime>(nullable: false),
                    VehicleId = table.Column<int>(nullable: true),
                    DriverId = table.Column<int>(nullable: true),
                    GasStationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refuels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refuels_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Refuels_GasStations_GasStationId",
                        column: x => x.GasStationId,
                        principalTable: "GasStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Refuels_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrafficTickets",
                columns: table => new
                {
                    CEP = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Neighborhood = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    UF = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DriverId = table.Column<int>(nullable: true),
                    VehicleId = table.Column<int>(nullable: true),
                    TrafficTicketDate = table.Column<DateTime>(nullable: false),
                    BilletExpiration = table.Column<DateTime>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Points = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    WasPaid = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafficTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrafficTickets_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrafficTickets_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_VehicleId",
                table: "Drivers",
                column: "VehicleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntranceAndExits_DriverId",
                table: "EntranceAndExits",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_EntranceAndExits_VehicleId",
                table: "EntranceAndExits",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_VehicleId",
                table: "Maintenances",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Refuels_DriverId",
                table: "Refuels",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Refuels_GasStationId",
                table: "Refuels",
                column: "GasStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Refuels_VehicleId",
                table: "Refuels",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TrafficTickets_DriverId",
                table: "TrafficTickets",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_TrafficTickets_VehicleId",
                table: "TrafficTickets",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntranceAndExits");

            migrationBuilder.DropTable(
                name: "Maintenances");

            migrationBuilder.DropTable(
                name: "Refuels");

            migrationBuilder.DropTable(
                name: "TrafficTickets");

            migrationBuilder.DropTable(
                name: "GasStations");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
