using APIFarm.Models;

namespace APIFarm.Repository.Interfaces
{
    public interface IWorkerRepository
    {
        ICollection<Worker> GetWorkers();
        Worker GetWorker(int id);
        ICollection<Worker> GetWorkersInFarm(int farmId);
    }
}
