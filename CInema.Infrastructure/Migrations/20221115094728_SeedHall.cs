using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CInema.Infrastructure.Migrations
{
    public partial class SeedHall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[] { 1, 30, "Small" });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[] { 2, 50, "Medium" });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[] { 3, 80, "Large" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
