using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRP.Data;
using SRP.Models;

namespace SRP.Pages.Categories
{
    //[BindProperties] for binding multiple properties
    public class CreateCategoryModel : PageModel
    {
        private readonly IRepository _repo;

        public CreateCategoryModel(IRepository repo)
        {
            _repo = repo;
        }
        [BindProperty]
        public Category Category { get; set; }
        
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (Category.Name == Category.DisplayOrder.ToString())
                ModelState.AddModelError("Category.Name", "Name cannot be exactly same with display order");
            if(ModelState.IsValid)
            {
                await _repo.AddCategoryAsync(Category);
                return RedirectToPage("Index");
            }
            return Page();
        }

      
    }
}
