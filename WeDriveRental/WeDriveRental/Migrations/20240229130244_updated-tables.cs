using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeDriveRental.Migrations
{
    /// <inheritdoc />
    public partial class updatedtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Model", "SekPrice" },
                values: new object[,]
                {
                    { 1, "Mercedes", "Mercedes-Benz C-Class", 1000m },
                    { 2, "Audi", "Audi RS6", 1500m },
                    { 3, "Audi", "Audi RSQ8", 2000m },
                    { 4, "Koenigsegg", "koenigsegg Agera", 3000m },
                    { 5, "Mercedes", "Mercedes G63 AMG", 2500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
