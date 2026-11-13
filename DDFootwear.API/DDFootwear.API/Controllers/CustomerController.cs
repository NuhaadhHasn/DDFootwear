using AutoMapper;
using DDFootwear.API.Data;
using DDFootwear.API.DTO;
using DDFootwear.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace DDFootwear.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepo _customerRepo;

        public CustomerController(ICustomerRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepo = repo;
        }

        [HttpPost]
        public ActionResult CreateCustomer(CustomerCreateDTO createDTO)
        {
            var customer = _mapper.Map<Customer>(createDTO);
            if (_customerRepo.CreateCustomer(customer))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerReadDTO>> GetCustomers()
        {
            var customers = _customerRepo.GetCustomer();
            return Ok(_mapper.Map<IEnumerable<CustomerReadDTO>>(customers));
        }

        [HttpGet("{CustomerId}", Name = "GetByCustomerId")]
        public ActionResult<CustomerReadDTO> GetCustomer(int CustomerId)
        {
            var customer = _customerRepo.GetCustomer(CustomerId);
            if (customer != null)
            {
                return Ok(_mapper.Map<CustomerReadDTO>(customer));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete]
        public ActionResult DeleteCustomer(int CustomerId)
        {
            var customer = _customerRepo.GetCustomer(CustomerId);
            if (customer != null)
            {
                _customerRepo.DeleteCustomer(customer);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        public ActionResult UpdateCustomer(CustomerCreateDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);
            if (_customerRepo.UpdateCustomer(customer))
            {
                return Ok();
            } else
            {
                return NotFound();
            }
        }

    }
}
