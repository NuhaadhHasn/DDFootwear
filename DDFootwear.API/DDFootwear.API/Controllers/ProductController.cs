using AutoMapper;
using DDFootwear.API.Data;
using DDFootwear.API.DTO;
using DDFootwear.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DDFootwear.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductRepo _productRepo;

        public ProductController(IProductRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _productRepo = repo;
        }

        [HttpPost]
        public ActionResult CreateProduct([FromForm] ProductCreateDTO createDTO, [FromForm] IFormFile productImg)
        {
            if (productImg != null && productImg.Length > 0)
            {

                // Generate a unique filename for the image (e.g., using a GUID)
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(productImg.FileName);

                // Define the file path where you want to save the uploaded image
                var filePath = Path.Combine("resources/images/", fileName); // Replace with your image folder path

                // Save the uploaded image to the specified file path
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    productImg.CopyTo(stream);
                }
                var product = _mapper.Map<Product>(createDTO);

                // Set the ImagePath property to the relative path where the image is saved
                product.ProductImg = "C:\\Users\\nuhaa\\source\\repos\\DDFootwear.API\\DDFootwear.API\\Resources\\images\\" + fileName;
                // product.ProductImg = "C:/Users/nuhaa/source/repos/DDFootwear.API/DDFootwear.API/Resources/images/" + fileName;

                if (_productRepo.CreateProduct(product))
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest("Image not provided.");
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDTO>> GetProducts()
        {
            var products = _productRepo.GetProduct();
            return Ok(_mapper.Map<IEnumerable<ProductReadDTO>>(products));
        }

        [HttpGet("{ProductId}", Name = "GetByProductId")]
        public ActionResult<ProductReadDTO> GetProduct(int ProductId)
        {
            var product = _productRepo.GetProduct(ProductId);
            if (product != null)
            {
                return Ok(_mapper.Map<ProductReadDTO>(product));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete]
        public ActionResult DeleteProduct(int ProductId)
        {
            var product = _productRepo.GetProduct(ProductId);
            if (product != null)
            {
                if (!string.IsNullOrEmpty(product.ProductImg) && System.IO.File.Exists(product.ProductImg))
                {
                    System.IO.File.Delete(product.ProductImg);
                }
                _productRepo.DeleteProduct(product);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        public ActionResult UpdateProduct([FromForm] ProductCreateDTO createDTO, [FromForm] IFormFile productImg)
        {
            if (productImg != null && productImg.Length > 0)
            {

                var existingProduct = _productRepo.GetProduct(createDTO.ProductId);
                if (existingProduct != null && !string.IsNullOrEmpty(existingProduct.ProductImg))
                {
                    // Delete the existing image
                    var imagePath = Path.Combine("resources/images", existingProduct.ProductImg);
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }

                // Generate a unique filename for the image (e.g., using a GUID)
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(productImg.FileName);

                // Define the file path where you want to save the uploaded image
                var filePath = Path.Combine("resources/images/", fileName); // Replace with your image folder path

                // Save the uploaded image to the specified file path
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    productImg.CopyTo(stream);
                }

                // _dbContext.Entry(existingProduct).State = EntityState.Detached;
                if (existingProduct != null)
                {
                    existingProduct.ProductName = createDTO.ProductName;
                    existingProduct.ProductDescription = createDTO.ProductDescription;
                    existingProduct.WholeSalePrice = createDTO.WholeSalePrice;
                    existingProduct.RetailPrice = createDTO.RetailPrice;
                    existingProduct.CostPrice = createDTO.CostPrice;
                    existingProduct.Stock = createDTO.Stock;
                    // Set the ImagePath property to the relative path where the image is saved
                    existingProduct.ProductImg = "C:\\Users\\nuhaa\\source\\repos\\DDFootwear.API\\DDFootwear.API\\Resources\\images\\" + fileName;
                }
                // product.ProductImg = "C:/Users/nuhaa/source/repos/DDFootwear.API/DDFootwear.API/Resources/images/" + fileName;

                if (_productRepo.UpdateProduct(existingProduct))
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest("Image not provided.");
            }
        }
    }
}
