using APIFarm.Data;
using APIFarm.Models;
using APIFarm.Repository.Interfaces;

namespace APIFarm.Repository
{
    public class FarmRepository : IFarmRepository
    {
        private readonly DataContext _context;

        public FarmRepository(DataContext context)
        {
            _context = context;
        }
        public Farm GetFarm(int id)
        {
            return _context.Farms.Where(f => f.Id == id).FirstOrDefault();
        }

        public ICollection<Farm> GetFarms()
        {
            return _context.Farms.OrderBy(f => f.Id).ToList();
        }

    }
}
