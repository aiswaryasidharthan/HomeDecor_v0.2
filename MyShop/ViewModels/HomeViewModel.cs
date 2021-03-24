using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Shop> productsonsale { get; set; }
    }
}
