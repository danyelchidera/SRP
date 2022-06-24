using SRP.Models;

namespace SRP.Data
{
    public interface IRepository
    {
        Task<Category> AddCategoryAsync(Category category);
        void UpdateCategoryAsync(Category category);
        IEnumerable<Category> GetCategories();
        Category GetCategory(int id);
        void Delete(int id);



    }
}
