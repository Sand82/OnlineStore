using System.ComponentModel.DataAnnotations;

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
    }
}
