using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCrab.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToproductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Product",
                columns: new[] { "Id", "Description", "ListPrice", "Name", "Price", "Price100", "Price50" },
                values: new object[,]
                {
                    { 1, "Beautiful Pent with 6 pockets", 60.0, "Levis Pent", 57.0, 48.0, 52.0 },
                    { 2, "Stunning necklace in heart shape", 70.0, "Diamond Necklace", 67.0, 58.0, 62.0 },
                    { 3, "Real gold ring made of 24 carat gold", 92.0, "24 Carat Gold Ring", 87.0, 78.0, 82.0 },
                    { 4, "Adidas perfume with a nice fragnence to use before workout", 30.0, "Adidas Perfume", 27.0, 18.0, 22.0 },
                    { 5, "Impress other people with rose fragnence.", 45.0, "Boss perfume", 37.0, 28.0, 32.0 },
                    { 6, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 99.0, "Fortune of Time", 90.0, 80.0, 85.0 },
                    { 7, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 40.0, "Dark Skies", 30.0, 20.0, 25.0 },
                    { 8, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 55.0, "Vanish in the Sunset", 50.0, 35.0, 40.0 },
                    { 9, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 70.0, "Cotton Candy", 65.0, 55.0, 60.0 },
                    { 10, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 30.0, "Rock in the Ocean", 27.0, 20.0, 25.0 },
                    { 11, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 25.0, "Leaves and Wonders", 23.0, 20.0, 22.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
