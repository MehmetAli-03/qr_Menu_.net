using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_pizza.Migrations
{
    /// <inheritdoc />
    public partial class AddKategoriTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KategoriAdi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "Id", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Pizza" },
                    { 2, "Citir" },
                    { 3, "Burger" },
                    { 4, "Icecek" },
                    { 5, "Borek" },
                    { 6, "Atistirmalik" },
                    { 7, "Tost" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "KategoriId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "KategoriId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "KategoriId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "KategoriId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "KategoriId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Image", "KategoriId", "Price1", "Price2", "ProductName", "Tanitim" },
                values: new object[,]
                {
                    { 6, "burger.jpg", 3, 260.0, null, "Burger1", "tavuk Burger" },
                    { 7, "burger.jpg", 3, 250.0, null, "Burger2", "tavuk Burger" },
                    { 8, "burger.jpg", 3, 240.0, null, "Burger3", "tavuk Burger" },
                    { 9, "burger2.jpg", 2, 230.0, null, "Çıtır1", "tavuk Burger" },
                    { 10, null, 5, 260.0, null, "Börek1", "tavuk Burger" },
                    { 11, null, 7, 260.0, null, "Tost2", "tavuk Burger" },
                    { 12, null, 4, 260.0, null, "İçecek1", null },
                    { 13, null, 6, 260.0, null, "Atistirmalik1", null },
                    { 20, "burger2.jpg", 2, 230.0, null, "Çıtır2", "tavuk Burger" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_KategoriId",
                table: "Products",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Kategori_KategoriId",
                table: "Products",
                column: "KategoriId",
                principalTable: "Kategori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Kategori_KategoriId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropIndex(
                name: "IX_Products_KategoriId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
