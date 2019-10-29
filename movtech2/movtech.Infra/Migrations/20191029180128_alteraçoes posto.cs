using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movtech.Infra.Migrations
{
    public partial class alteraçoesposto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "Refuels",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 15, 1, 28, 660, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 14, 16, 20, 937, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Refuels_DriverId",
                table: "Refuels",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Refuels_Drivers_DriverId",
                table: "Refuels",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Refuels_Drivers_DriverId",
                table: "Refuels");

            migrationBuilder.DropIndex(
                name: "IX_Refuels_DriverId",
                table: "Refuels");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Refuels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 14, 16, 20, 937, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 15, 1, 28, 660, DateTimeKind.Local));
        }
    }
}
