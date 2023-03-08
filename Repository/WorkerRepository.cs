using APIFarm.Data;
using APIFarm.Models;
using APIFarm.Repository.Interfaces;

namespace APIFarm.Repository
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly DataContext _context;

        public WorkerRepository(DataContext context)
        {
            _context = context;
        }

        public Worker GetWorker(int id)
        {
            return _context.Workers.Where(w => w.Id == id).FirstOrDefault();
        }

        public ICollection<Worker> GetWorkers()
        {
            return _context.Workers.OrderBy(w => w.Id).ToList();
        }

        public ICollection<Worker> GetWorkersInFarm(int farmId)
        {
            return _context.Workers.Where(w => w.FarmId == farmId).ToList();
        }
    }
}
