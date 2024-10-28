using System.ComponentModel.DataAnnotations;

namespace FashionFoundry.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Price")]
        public decimal Price {  get; set; }
    }
}
