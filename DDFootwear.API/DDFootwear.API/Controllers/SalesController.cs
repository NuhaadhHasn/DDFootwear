using AutoMapper;
using DDFootwear.API.Data;
using DDFootwear.API.DTO;
using DDFootwear.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace DDFootwear.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISaleRepo _salesRepo;

        public SalesController(ISaleRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _salesRepo = repo;
        }

        [HttpPost]
        public ActionResult CreateSale(SalesCreateDTO createDTO)
        {
            var sale = _mapper.Map<Sale>(createDTO);
            if (_salesRepo.CreateSale(sale))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<SalesReadDTO>> GetSales()
        {
            var sales = _salesRepo.GetSale();
            return Ok(_mapper.Map<IEnumerable<SalesReadDTO>>(sales));
        }

        [HttpGet("{Id}", Name = "GetBySalesId")]
        public ActionResult<SalesReadDTO> GetSale(int Id)
        {
            var sale = _salesRepo.GetSale(Id);
            if (sale != null)
            {
                return Ok(_mapper.Map<SalesReadDTO>(sale));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete]
        public ActionResult DeleteSale(int Id)
        {
            var sale = _salesRepo.GetSale(Id);
            if (sale != null)
            {
                _salesRepo.DeleteSale(sale);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPut]
        public ActionResult UpdateSale(SalesCreateDTO createDTO)
        {
            var sale = _mapper.Map<Sale>(createDTO);
            if (_salesRepo.UpdateSale(sale))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
