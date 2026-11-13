using System.ComponentModel.DataAnnotations;

namespace DDFootwear.API.DTO
{
    public class CustomerCreateDTO
    {
        [Required] public int CustomerId { get; set; }
        [Required] public string CustomerName { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
