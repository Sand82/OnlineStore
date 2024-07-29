using System.ComponentModel.DataAnnotations;

using static OnlineStore.Domain.Constants.ValidationConstants.CategoryConstant;

namespace OnlineStore.Domain.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameLength)]
        public string? Name { get; set; }

        public ICollection<Item>? Items { get; set; }
        
        public int MainCategoryId { get; set; }

        public MainCategory? MainCategory { get; set; }
    }
}
