using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShop.Migrations
{
    public partial class seedingImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\ blacksofaT.jpg", "\\Images\\blacksofa.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\redT.jpg", "\\Images\\red.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\ whiteT.jpg", "\\Images\\White.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\ GreyT.jpg", "\\Images\\Grey.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\ BedT.jpg", "\\Images\\Bed.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\ bedwoodT.jpg", "\\Images\\bedwood.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\ KitchenT.jpg", "\\Images\\Kitchen.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\ plateT.jpg", "\\Images\\plate.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\ steelT.jpg", "\\Images\\Steel.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  \\Images\\Thumbnails\\ blacksofaT.jpg", "  \\Images\\blacksofa.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\ redT.jpg    ", "\\Images\\red.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  \\Images\\Thumbnails\\ whiteT.jpg  ", "  \\Images\\White.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  \\Images\\Thumbnails\\ GreyT.jpg  ", "  \\Images\\Grey.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  \\Images\\Thumbnails\\ BedT.jpg  ", "  \\Images\\Bed.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  \\Images\\Thumbnails\\ bedwoodT.jpg  ", "  \\Images\\bedwood.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  \\Images\\Thumbnails\\ KitchenT.jpg  ", "  \\Images\\Kitchen.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  \\Images\\Thumbnails\\ plateT.jpg  ", "  \\Images\\plate.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  \\Images\\Thumbnails\\ steelT.jpg  ", "  \\Images\\Steel.jpg    " });
        }
    }
}
