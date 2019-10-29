using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movtech.Infra.Migrations
{
    public partial class decimalconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "TrafficTickets",
                type: "decimal(10, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 16, 37, 30, 587, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 15, 45, 5, 100, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "TrafficTickets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 15, 45, 5, 100, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 16, 37, 30, 587, DateTimeKind.Local));
        }
    }
}
