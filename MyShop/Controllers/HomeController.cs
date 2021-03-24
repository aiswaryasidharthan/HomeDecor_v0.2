using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyShop.Models;
using MyShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IShopRepository _shopRepository;
        public HomeController(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                productsonsale = _shopRepository.Getproductsonsale
            };
            return View(homeViewModel);
        }
    }
}
