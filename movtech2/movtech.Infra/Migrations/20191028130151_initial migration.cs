using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movtech.Infra.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    InGarage = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.UniqueConstraint("AK_Vehicles_LicensePlate", x => x.LicensePlate);
                    table.UniqueConstraint("AK_Vehicles_Renavam", x => x.Renavam);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
