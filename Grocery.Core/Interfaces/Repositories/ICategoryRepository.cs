namespace Grocery.Core.Interfaces.Repositories;

using Grocery.Core.Models;

public interface ICategoryRepository
{
    public List<Category> GetAll();
    public Category? Get(int id);
}