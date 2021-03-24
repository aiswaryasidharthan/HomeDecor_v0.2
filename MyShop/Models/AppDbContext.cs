using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class AppDbContext :IdentityDbContext<IdentityUser>
        //public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
           base(options)
        {

        }
        ////Adding DB set of the products and categories////
        public DbSet<Shop> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        ////Adding Database set of shoppingcart////
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        // Adding order and order details//
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Categoryid = 1,
                CategoryName = "Living Room "
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Categoryid = 2,
                CategoryName = "Bedroom"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Categoryid = 3,
                CategoryName = "Kitchen and Dining"
            });

            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 1,
                Name = "LUXURY SOFA",
                Price = 250.5M,
                Description = "Warm and welcoming, neat, and stylish. The supporting seat cushions, the cover’s soft finish and the tight fit gives this sofa a perfect balance between its comfort, functions, and look. The product is guaranteed for 5years,covering accidental damage",
                CategoryId = 1,
                ImageUrl="/Images/logo.png",
                ImageThumbnailUrl="/Images/logo.png",
                IsOnSale = true,
                OnStock = true


            });
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 2,
                Name = "RED SOFA",
                Price = 150.5M,
                Description = "This Customised Red Sofa can be perfect for Joint families. It adds colour to your living room, style your living area, the material is washable and guaranteed for 10 years. Can easily assemble with the guide! Just relax after your work!!",
                CategoryId = 1,
                ImageUrl="/Images/logo.png",
                ImageThumbnailUrl="/Images/logo.png",
                IsOnSale = true,
                OnStock = true


            });
          
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 3,
                Name = "PERFECT WHITE",
                Price = 149.99M,
                Description = "If you like the way it looks you have to try it! The deep seats, moveable back cushions and suspension fabric make this seating very comfortable. Create your own combination, sit back and relax ",
                CategoryId = 1,
                ImageUrl="\\Images\\White.jpg",
                ImageThumbnailUrl="\\Images\\Thumbnails\\ whiteT.jpg",
                IsOnSale = true,
                OnStock = true


            });
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 4,
                Name = "STYLISH GREY",
                Price = 120.99M,
                Description = " A small sofa with a big heart that fits perfectly wherever space is limited. Smartly designed, lightweight, a comfortable padded cover and uses less materials. Simple design perfect for small home ",
                CategoryId = 1,
                ImageUrl="\\Images\\Grey.jpg",
                ImageThumbnailUrl="\\Images\\Thumbnails\\ GreyT.jpg",
                IsOnSale = true,
                OnStock = true


            });
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 5,
                Name = "DOUBLE BED",
                Price = 320.00M,
                Description = "Comes with storage space  in the drawers for clothes, extra duvets with movable  position headboard’s box . Altogether make it a perfect combination!! The wood finish gives a luxury comfort! Perfect one for Master Bedroom ",
                CategoryId = 2,
                ImageUrl="\\Images\\Bed.jpg",
                ImageThumbnailUrl="\\Images\\Thumbnails\\ BedT.jpg",
                IsOnSale = true,
                OnStock = true


            });
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 6,
                Name = "BED FRAME",
                Price = 280.50M,
                Description = "Go Organic!!! Made with natural materials such as birch and leather, and fine carpentry details create a neat and airy look. This wooden bedframe is designed with imported wood from different countries and blended with fine finishing ",
                CategoryId = 2,
                ImageUrl="\\Images\\bedwood.jpg",
                ImageThumbnailUrl="\\Images\\Thumbnails\\ bedwoodT.jpg",
                IsOnSale = true,
                OnStock = true


            });
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 7,
                Name = "DINING TABLE",
                Price = 200.50M,
                Description = " A simple and sturdy set that’s perfect for your breakfast nook or smaller dining area. The solid pine holds up well over time and will endure all the family meals and activities around the table ",
                CategoryId = 3,
                ImageUrl="\\Images\\Kitchen.jpg",
                ImageThumbnailUrl="\\Images\\Thumbnails\\ KitchenT.jpg",
                IsOnSale = true,
                OnStock = true


            });
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 8,
                Name = "DINNER SET",
                Price = 50.00M,
                Description = "Crafted from durable porcelain with a quirky design and modern gloss finish, this comes as a  12 piece dinner set comes complete with four dinner plates, four side plates and four bowls which are dishwasher and microwave safe for added convenience. ",
                CategoryId = 3,
                ImageUrl="\\Images\\plate.jpg",
                ImageThumbnailUrl="\\Images\\Thumbnails\\ plateT.jpg",
                IsOnSale = true,
                OnStock = true


            });
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 9,
                Name = "STEAMER",
                Price = 80.50M,
                Description = "The three-tier steamer is finished with non-stick surfaces and is guaranteed for 10 years. Durable, supports gas heating and electric hobs. ",
                CategoryId = 3,
                ImageUrl="\\Images\\Steel.jpg",
                ImageThumbnailUrl="\\Images\\Thumbnails\\ steelT.jpg",
                IsOnSale = true,
                OnStock = true


            });
           
        }


    }

}
