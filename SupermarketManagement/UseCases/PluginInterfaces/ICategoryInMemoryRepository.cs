using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.PluginInterfaces
{
    public interface ICategoryInMemoryRepository
    {
         IEnumerable<Category> GetCategories();
        void AddCategory(Category category);

        void UpdateCategory(Category category);

        Category GetCategoryById(int categoryId);
		void DeleteCategory(int categoryId);
	}
}
