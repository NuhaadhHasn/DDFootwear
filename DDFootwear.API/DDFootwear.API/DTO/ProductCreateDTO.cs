using System.ComponentModel.DataAnnotations;

namespace DDFootwear.API.DTO
{
    public class ProductCreateDTO
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public int WholeSalePrice { get; set; }
        [Required]
        public int RetailPrice { get; set; }
        [Required]
        public int CostPrice { get; set; }
        [Required]
        public int Stock { get; set; }
        public IFormFile ProductImg { get; set; }
    }
}
