using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 12, 21, 54, 28, 276, DateTimeKind.Local).AddTicks(6994), "Jordan", "Davila", new DateTime(2024, 1, 12, 21, 54, 28, 276, DateTimeKind.Local).AddTicks(7049) },
                    { 2, new DateTime(2024, 1, 12, 21, 54, 28, 276, DateTimeKind.Local).AddTicks(7056), "Giovanni", "Krueger", new DateTime(2024, 1, 12, 21, 54, 28, 276, DateTimeKind.Local).AddTicks(7058) },
                    { 3, new DateTime(2024, 1, 12, 21, 54, 28, 276, DateTimeKind.Local).AddTicks(7062), "Marjorie", "Nolan", new DateTime(2024, 1, 12, 21, 54, 28, 276, DateTimeKind.Local).AddTicks(7064) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
