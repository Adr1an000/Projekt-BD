using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _appDbContext.Categories;
        }

        public Category GetCategoryByID(int categoryID)
        {
            return _appDbContext.Categories.FirstOrDefault(s => s.Id == categoryID);
        }
    }
}
