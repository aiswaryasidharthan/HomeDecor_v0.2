﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }

    }
}
