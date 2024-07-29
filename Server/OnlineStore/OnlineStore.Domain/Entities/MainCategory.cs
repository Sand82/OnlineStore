using System.ComponentModel.DataAnnotations;

using static OnlineStore.Domain.Constants.ValidationConstants.ItemConstant;

namespace OnlineStore.Domain.Models
{
    public class MainCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameLength)]
        public string? Name { get; set; }        

        public ICollection<Category>? Categories { get; set; }
    }
}
