using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PluginInterfaces;

namespace Plugins.DataStore.InMemory
{
	public class ProductInMemoryRepository : IProductRepository
	{
		private List<Product> products;

		public ProductInMemoryRepository()
		{
			//Initializing with default products.

			products = new List<Product>()
			{
				new Product {ProductId = 1, CategoryId = 1, Name = "Bournvita", Quantity = 100, Price = 750},
				new Product {ProductId = 2, CategoryId = 1, Name = "Frosty Ale", Quantity = 200, Price = 500},
				new Product {ProductId = 3, CategoryId = 2, Name = "SugarVille Coconut Bread", Quantity = 300, Price = 500},
				new Product {ProductId = 4, CategoryId = 2, Name = "SugarVille Banana Bread", Quantity = 100, Price = 3500}
			};
		}

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
                return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;

            }
            else
            {
                product.ProductId = 1;
            }


            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
		{
			return products;
		}
	}
}
