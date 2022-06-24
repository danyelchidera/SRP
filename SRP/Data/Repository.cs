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

        public void Delete(int id)
        {
            var cat = _context.Categories.Find(id);
            _context.Categories.Remove(cat);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories;
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Find(id);
            
        }

        public void UpdateCategoryAsync(Category category)
        {
            var res = _context.Update(category);
            _context.SaveChanges();
        }

        
    }
}
