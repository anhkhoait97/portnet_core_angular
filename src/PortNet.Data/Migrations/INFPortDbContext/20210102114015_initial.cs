using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortNet.Data.Migrations.INFPortDbContext
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationID = table.Column<short>(type: "smallint", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enabled = table.Column<byte>(type: "tinyint", nullable: false),
                    ID_GroupRight = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
