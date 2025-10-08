namespace Grocery.Core.Interfaces.Repositories;

using Grocery.Core.Models;
public interface IProductCategoryRepository
{
    public List<ProductCategory> GetAll();
}