using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryInMemoryRepository categoryInMemoryRepository;

        public EditCategoryUseCase(ICategoryInMemoryRepository categoryInMemoryRepository)
        {
            this.categoryInMemoryRepository = categoryInMemoryRepository;
        }
        public void Execute(Category category)
        {
            categoryInMemoryRepository.UpdateCategory(category);
        }
    }
}
