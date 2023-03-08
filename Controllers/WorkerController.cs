using APIFarm.DTO;
using APIFarm.Services;
using APIFarm.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFarm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _workerService;
        private readonly IMapper _mapper;

        public WorkerController(IWorkerService workerService, IMapper mapper)
        {
            _workerService = workerService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetWorkers()
        {
            var workers = _mapper.Map<List<FarmDto>>(_workerService.GetWorkers());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(workers);
        }

        [HttpGet("{id}")]
        public IActionResult GetWorker(int id)
        {
            var worker = _mapper.Map<FarmDto>(_workerService.GetWorker(id));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(worker);
        }
    }
}
