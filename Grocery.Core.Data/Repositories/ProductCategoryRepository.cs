using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories;

public class ProductCategoryRepository : IProductCategoryRepository
{
    private readonly List<ProductCategory> productCategories;

    public ProductCategoryRepository()
    {
        productCategories =
        [
            new ProductCategory(1, "test", 1, 3),
            new ProductCategory(2, "test", 3, 2)
        ];
    }


    public List<ProductCategory> GetAll()
    {
        return productCategories;
    }
    
}