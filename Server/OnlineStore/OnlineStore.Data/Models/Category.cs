using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineStore.Data.Constants.ValidationConstants.CategoryConstant;

namespace OnlineStore.Data.Models
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
