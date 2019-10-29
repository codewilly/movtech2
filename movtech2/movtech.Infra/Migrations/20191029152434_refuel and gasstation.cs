using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movtech.Infra.Migrations
{
    public partial class refuelandgasstation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 12, 24, 34, 733, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 28, 16, 28, 23, 510, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "GasStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<string>(maxLength: 14, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Address = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasStations", x => x.Id);
                    table.UniqueConstraint("AK_GasStations_CNPJ", x => x.CNPJ);
                });

            migrationBuilder.CreateTable(
                name: "Refuels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalValue = table.Column<double>(nullable: false),
                    LiterValue = table.Column<double>(nullable: false),
                    Liters = table.Column<float>(nullable: false),
                    FuelType = table.Column<int>(nullable: false),
                    RefuelDate = table.Column<DateTime>(nullable: false),
                    VehicleId = table.Column<int>(nullable: true),
                    GasStationId = table.Column<int>(nullable: true),
                    GasStationId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refuels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refuels_GasStations_GasStationId",
                        column: x => x.GasStationId,
                        principalTable: "GasStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Refuels_GasStations_GasStationId1",
                        column: x => x.GasStationId1,
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

            migrationBuilder.CreateIndex(
                name: "IX_Refuels_GasStationId",
                table: "Refuels",
                column: "GasStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Refuels_GasStationId1",
                table: "Refuels",
                column: "GasStationId1");

            migrationBuilder.CreateIndex(
                name: "IX_Refuels_VehicleId",
                table: "Refuels",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Refuels");

            migrationBuilder.DropTable(
                name: "GasStations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 28, 16, 28, 23, 510, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 12, 24, 34, 733, DateTimeKind.Local));
        }
    }
}
