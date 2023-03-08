using APIFarm.DTO;
using APIFarm.Models;
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

        [HttpPut("{id}")]
        public IActionResult UpdateWorker(WorkerDto worker)
        {
            _workerService.UpdateWorker(_mapper.Map<Worker>(worker));
            return Ok(worker);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWorker(int id)
        {
            _workerService.DeleteWorker(id);
            return Ok(id);
        }

        [HttpPost]
        public IActionResult CreateFarm(WorkerDto worker)
        {
            _workerService.CreateWorker(_mapper.Map<Worker>(worker));
            return Ok(worker);
        }
    }
}
