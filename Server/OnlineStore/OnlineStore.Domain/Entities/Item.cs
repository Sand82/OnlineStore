using System.ComponentModel.DataAnnotations;

using static OnlineStore.Domain.Constants.ValidationConstants.ItemConstant;

namespace OnlineStore.Domain.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameLength)]
        public string? Name { get; set; }

        [Required]
        [Range(CodeMinValue, CodeMaxValue)]
        public int Code {  get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string? Description {  get; set; }

        [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(ImageUrlLength)]
        public string? ImageUrl { get; set; }

        public ICollection<Category>? Categories { get; set; }       
    }
}
