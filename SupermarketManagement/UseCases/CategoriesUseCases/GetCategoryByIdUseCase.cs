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
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryInMemoryRepository categoryInMemoryRepository;

        public GetCategoryByIdUseCase(ICategoryInMemoryRepository categoryInMemoryRepository)
        {
            this.categoryInMemoryRepository = categoryInMemoryRepository;
        }
        public Category Execute(int categoryId)
        {
            return categoryInMemoryRepository.GetCategoryById(categoryId);
        }
    }
}
