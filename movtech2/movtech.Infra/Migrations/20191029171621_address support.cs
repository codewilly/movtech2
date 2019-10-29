using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movtech.Infra.Migrations
{
    public partial class addresssupport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "GasStations");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Drivers");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "GasStations",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "GasStations",
                maxLength: 9,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "GasStations",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "GasStations",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "GasStations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "GasStations",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UF",
                table: "GasStations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 14, 16, 20, 937, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 12, 26, 58, 732, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Drivers",
                maxLength: 9,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Drivers",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "Drivers",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Drivers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Drivers",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UF",
                table: "Drivers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEP",
                table: "GasStations");

            migrationBuilder.DropColumn(
                name: "City",
                table: "GasStations");

            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "GasStations");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "GasStations");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "GasStations");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "GasStations");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Drivers");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "GasStations",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 18);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "GasStations",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 29, 12, 26, 58, 732, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 29, 14, 16, 20, 937, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Drivers",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
