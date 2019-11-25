using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movtech.Infra.Migrations
{
    public partial class removidomaintenancetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaintenanceType",
                table: "Maintenances");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MaintenanceDate",
                table: "Maintenances",
                nullable: false,
                defaultValue: new DateTime(2019, 11, 23, 19, 47, 13, 939, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 30, 11, 34, 46, 151, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 11, 23, 19, 47, 13, 925, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 30, 11, 34, 46, 138, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MaintenanceDate",
                table: "Maintenances",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 30, 11, 34, 46, 151, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 11, 23, 19, 47, 13, 939, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "MaintenanceType",
                table: "Maintenances",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EntranceAndExits",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 30, 11, 34, 46, 138, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 11, 23, 19, 47, 13, 925, DateTimeKind.Local));
        }
    }
}
