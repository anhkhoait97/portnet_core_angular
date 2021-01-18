using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortNet.Data.Migrations.INFPortDbContext
{
    public partial class NewTablesInfPort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INSFunctions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Description = table.Column<string>(type: "NVarChar", maxLength: 50, nullable: false),
                    Visible = table.Column<byte>(type: "Tinyint", nullable: false),
                    RefPath = table.Column<string>(type: "Varchar", maxLength: 144, nullable: true),
                    Parent = table.Column<int>(type: "Int", nullable: false),
                    Type = table.Column<byte>(type: "Tinyint", nullable: false),
                    Level = table.Column<short>(type: "Smallint", nullable: false),
                    Level_1 = table.Column<short>(type: "Smallint", nullable: false),
                    Param = table.Column<string>(type: "Varchar", maxLength: 255, nullable: true),
                    IsType = table.Column<int>(type: "Int", nullable: true),
                    RefPathNew = table.Column<string>(type: "Varchar", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSFunctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "2, 10"),
                    FunctionId = table.Column<int>(type: "Int", nullable: false),
                    GroupId = table.Column<int>(type: "Int", nullable: false),
                    AUpdate = table.Column<byte>(type: "Tinyint", nullable: false),
                    AInsert = table.Column<byte>(type: "Tinyint", nullable: false),
                    ARemove = table.Column<byte>(type: "Tinyint", nullable: false),
                    ADetail = table.Column<byte>(type: "Tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INSFunctions");

            migrationBuilder.DropTable(
                name: "Rules");
        }
    }
}
