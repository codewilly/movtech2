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
                name: "Brokers",
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
                    Phone = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    ResponsibleBroker = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brokers", x => x.Id);
                    table.UniqueConstraint("AK_Brokers_CNPJ", x => x.CNPJ);
                });

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
                name: "Insurers",
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
                    Phone = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurers", x => x.Id);
                    table.UniqueConstraint("AK_Insurers_CNPJ", x => x.CNPJ);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(maxLength: 14, nullable: false),
                    Password = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("AK_Users_CPF", x => x.CPF);
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
                    InGarage = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Status = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    LastMaintenanceDate = table.Column<DateTime>(nullable: false),
                    LastMaintenanceKms = table.Column<float>(nullable: false),
                    LastTireChangeKms = table.Column<float>(nullable: false),
                    LastOilChangeKms = table.Column<float>(nullable: false),
                    NeedsMaintenance = table.Column<bool>(nullable: false),
                    NeedsChangeTires = table.Column<bool>(nullable: false),
                    NeedsChangeOil = table.Column<bool>(nullable: false),
                    InsurenceId = table.Column<int>(nullable: true)
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
                name: "Insurences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasInsurenceClaim = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    BeginOfVigency = table.Column<DateTime>(nullable: false),
                    EndOfVigency = table.Column<DateTime>(nullable: false),
                    BonusClass = table.Column<int>(nullable: false),
                    CINumber = table.Column<string>(nullable: false),
                    PolicyNumber = table.Column<string>(nullable: false),
                    InsurerId = table.Column<int>(nullable: false),
                    BrokerId = table.Column<int>(nullable: true),
                    VehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurences_Brokers_BrokerId",
                        column: x => x.BrokerId,
                        principalTable: "Brokers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Insurences_Insurers_InsurerId",
                        column: x => x.InsurerId,
                        principalTable: "Insurers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insurences_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaintenanceDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 12, 12, 18, 55, 43, 609, DateTimeKind.Local)),
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
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 12, 12, 18, 55, 43, 592, DateTimeKind.Local)),
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
                    CEP = table.Column<string>(maxLength: 9, nullable: true),
                    Street = table.Column<string>(maxLength: 100, nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Neighborhood = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
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

            migrationBuilder.CreateTable(
                name: "InsurenceClaims",
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
                    InsurenceId = table.Column<int>(nullable: false),
                    InsurenceClaimDate = table.Column<DateTime>(nullable: false),
                    OccurrenceNumber = table.Column<string>(nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    InsurenceClaimNumber = table.Column<string>(nullable: false),
                    InsurenceClaimType = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurenceClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsurenceClaims_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsurenceClaims_Insurences_InsurenceId",
                        column: x => x.InsurenceId,
                        principalTable: "Insurences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_InsurenceClaims_DriverId",
                table: "InsurenceClaims",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurenceClaims_InsurenceId",
                table: "InsurenceClaims",
                column: "InsurenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurences_BrokerId",
                table: "Insurences",
                column: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurences_InsurerId",
                table: "Insurences",
                column: "InsurerId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurences_VehicleId",
                table: "Insurences",
                column: "VehicleId",
                unique: true);

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
                name: "InsurenceClaims");

            migrationBuilder.DropTable(
                name: "Maintenances");

            migrationBuilder.DropTable(
                name: "Refuels");

            migrationBuilder.DropTable(
                name: "TrafficTickets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Insurences");

            migrationBuilder.DropTable(
                name: "GasStations");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Brokers");

            migrationBuilder.DropTable(
                name: "Insurers");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
