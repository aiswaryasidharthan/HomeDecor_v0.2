using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopRepository _shopRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext _appDbContext;



        public ShopController(IShopRepository shopRepository, ICategoryRepository categoryRepository, AppDbContext appDbContext)
        {
            _shopRepository = shopRepository;
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;

        }

        //Returning as list//
      /*  public IActionResult List()
        {
            *//*  ViewBag.current = "Best seller";
              return View(_shopRepository.Getallproducts);*//*
            var shopListViewModel = new ShopListViewModel();
               shopListViewModel.Products = _shopRepository.Getallproducts;
               shopListViewModel.CurrentCategory = "Best sellers";
                return View(shopListViewModel);


        }
*/
        //For Dropdown view//
        public ViewResult List(string category)
        {
            IEnumerable<Shop> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _shopRepository.Getallproducts.OrderBy(c => c.CategoryId);
                currentCategory = "All Products";
            }
            else
            {
                products = _shopRepository.Getallproducts.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ShopListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var shop = _shopRepository.GetShopById(id);
            if (shop == null)
                return NotFound();
            return View(shop);

        }

        //Search products
        [HttpGet]
        public async Task<IActionResult> ProductSearch(string prdSearch)
        {
            ViewData["GetProducts"] = prdSearch;
            var prdQuery = from x in _appDbContext.Products select x;
            if (!String.IsNullOrEmpty(prdSearch))
            {
                prdQuery = prdQuery.Where(x => x.Name.Contains(prdSearch) || x.Description.Contains(prdSearch));
            }

            return View(new ShopListViewModel
                 {
                Products = prdQuery,
                CurrentCategory = ""
                  });
        }



    }
}
