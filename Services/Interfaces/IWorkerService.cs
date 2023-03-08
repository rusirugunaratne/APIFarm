using APIFarm.Models;

namespace APIFarm.Services.Interfaces
{
    public interface IWorkerService
    {
        ICollection<Worker> GetWorkers();
        Worker GetWorker(int id);
        ICollection<Worker> GetWorkersInFarm(int farmId);
    }
}
