namespace DDFootwear.API.DTO
{
    public class SalesReadDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string ProductImagePath { get; set; }
    }
}
