using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    public class AdminController :Controller
    {
        private readonly AppDbContext _appDbContext;
        public AdminController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shop()
        {
            var shopViewModel = new ShopViewModel
            {
                Products = _appDbContext.Products.ToList()
            };
            return View(shopViewModel);
        }



            
        
    }
}
