using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseExpiratiomTracker3.Migrations
{
    /// <inheritdoc />
    public partial class createLicensesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "licensesTable3",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endingAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_licensesTable3", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "licensesTable3");
        }
    }
}
