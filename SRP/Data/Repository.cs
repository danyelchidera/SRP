using SRP.Models;

namespace SRP.Data
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<Category> AddCategoryAsync(Category category)
        {
            var res =await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return res.Entity;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories;
        }
    }
}
