using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategoryByID(int categoryID);

        void AddCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(Category category);
    }
}
