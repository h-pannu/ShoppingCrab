using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCrab.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyCategoryProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                schema: "dbo",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CategoryId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                schema: "dbo",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                schema: "dbo",
                table: "Product",
                column: "CategoryId",
                principalSchema: "dbo",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                schema: "dbo",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                schema: "dbo",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                schema: "dbo",
                table: "Product");
        }
    }
}
