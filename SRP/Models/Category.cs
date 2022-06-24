using System.ComponentModel.DataAnnotations;

namespace SRP.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Display Order")]
        public int DisplayOrder { get; set; }
    }
}
