using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_pizza.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "Price1");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price2",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Price2" },
                values: new object[] { "pizza.jpg", 320 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Price2" },
                values: new object[] { "pizza.jpg", 320 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Price2" },
                values: new object[] { "pizza.jpg", 320 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Price2" },
                values: new object[] { "pizza.jpg", 320 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Image", "Price2" },
                values: new object[] { "pizza.jpg", 320 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price2",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Price1",
                table: "Products",
                newName: "Price");
        }
    }
}
