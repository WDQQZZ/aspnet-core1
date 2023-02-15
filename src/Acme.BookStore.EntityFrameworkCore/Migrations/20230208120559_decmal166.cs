using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStore.Migrations
{
    public partial class decmal166 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppWarehouseModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    trayAZero = table.Column<int>(type: "int", nullable: false),
                    trayHairGermAOne = table.Column<int>(type: "int", nullable: false),
                    traySucceedATwo = table.Column<int>(type: "int", nullable: false),
                    trayDetectionOkAThree = table.Column<int>(type: "int", nullable: false),
                    trayBearingBOne = table.Column<int>(type: "int", nullable: false),
                    trayBearingBTwo = table.Column<int>(type: "int", nullable: false),
                    trayBearingBZero = table.Column<int>(type: "int", nullable: false),
                    trayScrewCZero = table.Column<int>(type: "int", nullable: false),
                    trayScrewCOne = table.Column<int>(type: "int", nullable: false),
                    trayScrewBearing = table.Column<int>(type: "int", nullable: false),
                    trayBearingDOne = table.Column<int>(type: "int", nullable: false),
                    trayBoltEOne = table.Column<int>(type: "int", nullable: false),
                    WarehouseNoTray = table.Column<int>(type: "int", nullable: false),
                    warehouseId = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWarehouseModels", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppWarehouseModels");
        }
    }
}
