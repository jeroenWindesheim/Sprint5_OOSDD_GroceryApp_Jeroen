namespace Grocery.Core.Models;

public partial class ProductCategory : Model
{
    public int ProductId;
    public int CategoryId;
    
    public ProductCategory(int id, string name, int productId, int categoryId) : base(id, name)
    {
        ProductId = productId;
        CategoryId = categoryId;
    }
}