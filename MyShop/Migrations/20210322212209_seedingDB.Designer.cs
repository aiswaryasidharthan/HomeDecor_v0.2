﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyShop.Models;

namespace MyShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210322212209_seedingDB")]
    partial class seedingDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyShop.Models.Category", b =>
                {
                    b.Property<int>("Categoryid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categorydescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Categoryid");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Categoryid = 1,
                            CategoryName = "Living Room "
                        },
                        new
                        {
                            Categoryid = 2,
                            CategoryName = "Bedroom"
                        },
                        new
                        {
                            Categoryid = 3,
                            CategoryName = "Kitchen and Dining"
                        });
                });

            modelBuilder.Entity("MyShop.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnStock")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ShopId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            CategoryId = 1,
                            Description = "Warm and welcoming, neat, and stylish. The supporting seat cushions, the cover’s soft finish and the tight fit gives this sofa a perfect balance between its comfort, functions, and look. The product is guaranteed for 5years,covering accidental damage",
                            ImageThumbnailUrl = "  \\Images\\Thumbnails\\ blacksofaT.jpg",
                            ImageUrl = "  \\Images\\blacksofa.jpg    ",
                            IsOnSale = true,
                            Name = "LUXURY SOFA",
                            OnStock = true,
                            Price = 250.5m
                        },
                        new
                        {
                            ShopId = 2,
                            CategoryId = 1,
                            Description = "This Customised Red Sofa can be perfect for Joint families. It adds colour to your living room, style your living area, the material is washable and guaranteed for 10 years. Can easily assemble with the guide! Just relax after your work!!",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\ redT.jpg    ",
                            ImageUrl = "\\Images\\red.jpg    ",
                            IsOnSale = true,
                            Name = "RED SOFA",
                            OnStock = true,
                            Price = 150.5m
                        },
                        new
                        {
                            ShopId = 3,
                            CategoryId = 1,
                            Description = "If you like the way it looks you have to try it! The deep seats, moveable back cushions and suspension fabric make this seating very comfortable. Create your own combination, sit back and relax ",
                            ImageThumbnailUrl = "  \\Images\\Thumbnails\\ whiteT.jpg  ",
                            ImageUrl = "  \\Images\\White.jpg    ",
                            IsOnSale = true,
                            Name = "PERFECT WHITE",
                            OnStock = true,
                            Price = 149.99m
                        },
                        new
                        {
                            ShopId = 4,
                            CategoryId = 1,
                            Description = " A small sofa with a big heart that fits perfectly wherever space is limited. Smartly designed, lightweight, a comfortable padded cover and uses less materials. Simple design perfect for small home ",
                            ImageThumbnailUrl = "  \\Images\\Thumbnails\\ GreyT.jpg  ",
                            ImageUrl = "  \\Images\\Grey.jpg    ",
                            IsOnSale = true,
                            Name = "STYLISH GREY",
                            OnStock = true,
                            Price = 120.99m
                        },
                        new
                        {
                            ShopId = 5,
                            CategoryId = 2,
                            Description = "Comes with storage space  in the drawers for clothes, extra duvets with movable  position headboard’s box . Altogether make it a perfect combination!! The wood finish gives a luxury comfort! Perfect one for Master Bedroom ",
                            ImageThumbnailUrl = "  \\Images\\Thumbnails\\ BedT.jpg  ",
                            ImageUrl = "  \\Images\\Bed.jpg    ",
                            IsOnSale = true,
                            Name = "DOUBLE BED",
                            OnStock = true,
                            Price = 320.00m
                        },
                        new
                        {
                            ShopId = 6,
                            CategoryId = 2,
                            Description = "Go Organic!!! Made with natural materials such as birch and leather, and fine carpentry details create a neat and airy look. This wooden bedframe is designed with imported wood from different countries and blended with fine finishing ",
                            ImageThumbnailUrl = "  \\Images\\Thumbnails\\ bedwoodT.jpg  ",
                            ImageUrl = "  \\Images\\bedwood.jpg    ",
                            IsOnSale = true,
                            Name = "BED FRAME",
                            OnStock = true,
                            Price = 280.50m
                        },
                        new
                        {
                            ShopId = 7,
                            CategoryId = 3,
                            Description = " A simple and sturdy set that’s perfect for your breakfast nook or smaller dining area. The solid pine holds up well over time and will endure all the family meals and activities around the table ",
                            ImageThumbnailUrl = "  \\Images\\Thumbnails\\ KitchenT.jpg  ",
                            ImageUrl = "  \\Images\\Kitchen.jpg    ",
                            IsOnSale = true,
                            Name = "DINING TABLE",
                            OnStock = true,
                            Price = 200.50m
                        },
                        new
                        {
                            ShopId = 8,
                            CategoryId = 3,
                            Description = "Crafted from durable porcelain with a quirky design and modern gloss finish, this comes as a  12 piece dinner set comes complete with four dinner plates, four side plates and four bowls which are dishwasher and microwave safe for added convenience. ",
                            ImageThumbnailUrl = "  \\Images\\Thumbnails\\ plateT.jpg  ",
                            ImageUrl = "  \\Images\\plate.jpg    ",
                            IsOnSale = true,
                            Name = "DINNER SET",
                            OnStock = true,
                            Price = 50.00m
                        },
                        new
                        {
                            ShopId = 9,
                            CategoryId = 3,
                            Description = "The three-tier steamer is finished with non-stick surfaces and is guaranteed for 10 years. Durable, supports gas heating and electric hobs. ",
                            ImageThumbnailUrl = "  \\Images\\Thumbnails\\ steelT.jpg  ",
                            ImageUrl = "  \\Images\\Steel.jpg    ",
                            IsOnSale = true,
                            Name = "STEAMER",
                            OnStock = true,
                            Price = 80.50m
                        });
                });

            modelBuilder.Entity("MyShop.Models.Shop", b =>
                {
                    b.HasOne("MyShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MyShop.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
