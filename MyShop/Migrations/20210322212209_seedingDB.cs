using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShop.Migrations
{
    public partial class seedingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Categoryid", "CategoryName", "Categorydescription" },
                values: new object[] { 1, "Living Room ", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Categoryid", "CategoryName", "Categorydescription" },
                values: new object[] { 2, "Bedroom", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Categoryid", "CategoryName", "Categorydescription" },
                values: new object[] { 3, "Kitchen and Dining", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ShopId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "Name", "OnStock", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Warm and welcoming, neat, and stylish. The supporting seat cushions, the cover’s soft finish and the tight fit gives this sofa a perfect balance between its comfort, functions, and look. The product is guaranteed for 5years,covering accidental damage", " \\Images\\Thumbnails\\ blacksofaT.jpg", "  \\Images\\blacksofa.jpg    ", true, "LUXURY SOFA", true, 250.5m },
                    { 2, 1, "This Customised Red Sofa can be perfect for Joint families. It adds colour to your living room, style your living area, the material is washable and guaranteed for 10 years. Can easily assemble with the guide! Just relax after your work!!", "\\Images\\Thumbnails\\ redT.jpg    ", "\\Images\\red.jpg    ", true, "RED SOFA", true, 150.5m },
                    { 3, 1, "If you like the way it looks you have to try it! The deep seats, moveable back cushions and suspension fabric make this seating very comfortable. Create your own combination, sit back and relax ", " \\Images\\Thumbnails\\ whiteT.jpg  ", "  \\Images\\White.jpg    ", true, "PERFECT WHITE", true, 149.99m },
                    { 4, 1, " A small sofa with a big heart that fits perfectly wherever space is limited. Smartly designed, lightweight, a comfortable padded cover and uses less materials. Simple design perfect for small home ", "  \\Images\\Thumbnails\\ GreyT.jpg  ", "  \\Images\\Grey.jpg    ", true, "STYLISH GREY", true, 120.99m },
                    { 5, 2, "Comes with storage space  in the drawers for clothes, extra duvets with movable  position headboard’s box . Altogether make it a perfect combination!! The wood finish gives a luxury comfort! Perfect one for Master Bedroom ", "  \\Images\\Thumbnails\\ BedT.jpg  ", "  \\Images\\Bed.jpg    ", true, "DOUBLE BED", true, 320.00m },
                    { 6, 2, "Go Organic!!! Made with natural materials such as birch and leather, and fine carpentry details create a neat and airy look. This wooden bedframe is designed with imported wood from different countries and blended with fine finishing ", "  \\Images\\Thumbnails\\ bedwoodT.jpg  ", "  \\Images\\bedwood.jpg    ", true, "BED FRAME", true, 280.50m },
                    { 7, 3, " A simple and sturdy set that’s perfect for your breakfast nook or smaller dining area. The solid pine holds up well over time and will endure all the family meals and activities around the table ", "  \\Images\\Thumbnails\\ KitchenT.jpg  ", "  \\Images\\Kitchen.jpg    ", true, "DINING TABLE", true, 200.50m },
                    { 8, 3, "Crafted from durable porcelain with a quirky design and modern gloss finish, this comes as a  12 piece dinner set comes complete with four dinner plates, four side plates and four bowls which are dishwasher and microwave safe for added convenience. ", "  \\Images\\Thumbnails\\ plateT.jpg  ", "  \\Images\\plate.jpg    ", true, "DINNER SET", true, 50.00m },
                    { 9, 3, "The three-tier steamer is finished with non-stick surfaces and is guaranteed for 10 years. Durable, supports gas heating and electric hobs. ", "  \\Images\\Thumbnails\\ steelT.jpg  ", "  \\Images\\Steel.jpg    ", true, "STEAMER", true, 80.50m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Categoryid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Categoryid",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Categoryid",
                keyValue: 3);
        }
    }
}
