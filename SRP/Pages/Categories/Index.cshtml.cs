using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRP.Data;
using SRP.Models;

namespace SRP.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repo;

        public IndexModel(IRepository repo)
        {
            _repo = repo;
            Categories = _repo.GetCategories();
        }

        public IEnumerable<Category> Categories { get; set; }
        public void OnGet()
        {
            
        }
    }
}
