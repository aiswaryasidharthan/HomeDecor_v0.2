using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.ViewModels.Admin
{
    public class ShopViewModel
    {
       
        public IEnumerable<Models.Shop> Products { get; set; }
    }
}
