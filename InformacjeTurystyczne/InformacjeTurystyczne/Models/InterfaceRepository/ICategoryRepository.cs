﻿using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Repository
{
    interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategoryByID(int categoryID);
    }
}