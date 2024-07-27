using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineStore.Data.Constants.ValidationConstants.ItemConstant;

namespace OnlineStore.Data.Models
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
