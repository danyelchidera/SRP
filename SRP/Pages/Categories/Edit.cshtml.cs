using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRP.Data;
using SRP.Models;

namespace SRP.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly IRepository _repo;

        public EditModel(IRepository repo)
        {
            _repo = repo;
        }
        [BindProperty]
        public Category Category { get; set; }

        public void OnGet(int id)
        {
            Category = _repo.GetCategory(id);
        }

        public IActionResult OnPost()
        {
            _repo.UpdateCategoryAsync(Category);
            return RedirectToPage("Index");
        }
    }
}
