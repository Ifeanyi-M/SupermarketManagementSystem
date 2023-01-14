using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryInMemoryRepository categoryInMemoryRepository;

        public DeleteCategoryUseCase(ICategoryInMemoryRepository categoryInMemoryRepository)
        {
            this.categoryInMemoryRepository = categoryInMemoryRepository;
        }
        public void Delete(int categoryId)
        {
            categoryInMemoryRepository.DeleteCategory(categoryId);
        }
    }
}
