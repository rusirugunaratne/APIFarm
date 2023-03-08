using APIFarm.Models;
using APIFarm.Repository.Interfaces;
using APIFarm.Services.Interfaces;

namespace APIFarm.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepository _workerRepository;

        public WorkerService(IWorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public bool CreateWorker(Worker worker)
        {
            return _workerRepository.CreateWorker(worker);
        }

        public bool DeleteWorker(int id)
        {
            return _workerRepository.DeleteWorker(_workerRepository.GetWorker(id));
        }

        public Worker GetWorker(int id)
        {
            return _workerRepository.GetWorker(id);
        }

        public ICollection<Worker> GetWorkers()
        {
            return _workerRepository.GetWorkers();
        }

        public ICollection<Worker> GetWorkersInFarm(int farmId)
        {
            return _workerRepository.GetWorkersInFarm(farmId);
        }

        public bool UpdateWorker(Worker worker)
        {
            return _workerRepository.UpdateWorker(worker);
        }
    }
}
