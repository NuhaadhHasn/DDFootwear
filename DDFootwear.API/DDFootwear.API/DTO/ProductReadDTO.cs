using System.ComponentModel.DataAnnotations;

namespace DDFootwear.API.DTO
{
    public class ProductReadDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int WholeSalePrice { get; set; }
        public int RetailPrice { get; set; }
        public int CostPrice { get; set; }
        public int Stock { get; set; }
        public string ProductImg { get; set; }
    }
}
