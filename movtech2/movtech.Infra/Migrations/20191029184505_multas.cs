using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movtech.Infra.Migrations
{
    public partial class multas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 15, 45, 5, 100, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 15, 1, 28, 660, DateTimeKind.Local));

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
                    Cost = table.Column<decimal>(nullable: false),
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
                name: "TrafficTickets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 15, 1, 28, 660, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 15, 45, 5, 100, DateTimeKind.Local));
        }
    }
}
