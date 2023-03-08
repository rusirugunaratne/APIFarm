using APIFarm.DTO;
using APIFarm.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFarm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmController : ControllerBase
    {
        private readonly IFarmService _farmService;
        private readonly IMapper _mapper;

        public FarmController(IFarmService farmService, IMapper mapper)
        {
            _farmService = farmService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFarms()
        {
            var farms = _mapper.Map<List<FarmDto>>(_farmService.GetFarms());
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(farms);
        }

        [HttpGet("{id}")]
        public IActionResult GetFarm(int id)
        {
            var farm = _mapper.Map<FarmDto>(_farmService.GetFarm(id));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(farm);
        }
    }
}
