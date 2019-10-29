using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movtech.Infra.Migrations
{
    public partial class refuelandgasstationcorretion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Refuels_GasStations_GasStationId1",
                table: "Refuels");

            migrationBuilder.DropIndex(
                name: "IX_Refuels_GasStationId1",
                table: "Refuels");

            migrationBuilder.DropColumn(
                name: "GasStationId1",
                table: "Refuels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 12, 26, 58, 732, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 12, 24, 34, 733, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GasStationId1",
                table: "Refuels",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 12, 24, 34, 733, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 12, 26, 58, 732, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Refuels_GasStationId1",
                table: "Refuels",
                column: "GasStationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Refuels_GasStations_GasStationId1",
                table: "Refuels",
                column: "GasStationId1",
                principalTable: "GasStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
