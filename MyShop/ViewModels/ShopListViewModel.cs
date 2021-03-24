using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.ViewModels
{
    public class ShopListViewModel
    {
        public IEnumerable<Shop> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
