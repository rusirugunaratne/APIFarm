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

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool CreateWorker(Worker worker)
        {
            _context.Workers.Add(worker);
            return Save();
        }

        public bool DeleteWorker(Worker worker)
        {
            _context.Remove(worker);
            return Save();
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

        public bool UpdateWorker(Worker worker)
        {
            _context.Update(worker);
            return Save();
        }
    }
}
