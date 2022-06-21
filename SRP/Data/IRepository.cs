using SRP.Models;

namespace SRP.Data
{
    public interface IRepository
    {
        Task<Category> AddCategoryAsync(Category category);
        IEnumerable<Category> GetCategories();



    }
}
