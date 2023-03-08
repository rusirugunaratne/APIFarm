using APIFarm.Models;

namespace APIFarm.Repository.Interfaces
{
    public interface IWorkerRepository
    {
        ICollection<Worker> GetWorkers();
        Worker GetWorker(int id);
        ICollection<Worker> GetWorkersInFarm(int farmId);
        bool CreateWorker(Worker worker);
        bool UpdateWorker(Worker worker);
        bool DeleteWorker(Worker worker);
    }
}
