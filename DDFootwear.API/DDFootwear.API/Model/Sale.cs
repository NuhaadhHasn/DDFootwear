using System.ComponentModel.DataAnnotations;

namespace DDFootwear.API.Model
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string CustomerPhone{ get; set; }
        public string ProductImagePath { get; set; }
    }
}
