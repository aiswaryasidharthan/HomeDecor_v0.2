using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public static ShoppingCart GetCart(IServiceProvider services)

        {

            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };

        }

        public void AddToCart(Shop shop, int amount)
        {
            var ShoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault( s => s.Shop.ShopId == shop.ShopId && s.ShoppingCartId == ShoppingCartId);
            if (ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Shop = shop,
                    Amount = amount
                };

                _appDbContext.ShoppingCartItems.Add(ShoppingCartItem);
            }
            else
            {
                ShoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }
        public int RemoveFromCart(Shop shop)
        {
            var ShoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Shop.ShopId == shop.ShopId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;
            if (ShoppingCartItem != null)
            {
                if (ShoppingCartItem.Amount > 1)
                {
                    ShoppingCartItem.Amount--;

                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(ShoppingCartItem);

                }
            }

            _appDbContext.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems??(ShoppingCartItems = _appDbContext.ShoppingCartItems.Where (c => c.ShoppingCartId == ShoppingCartId).Include(s => s.Shop).ToList());
        }
        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);
            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId) .Select(c => c.Shop.Price * c.Amount).Sum();
            return total;
        }
    }


}

