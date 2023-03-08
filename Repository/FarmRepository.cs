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

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public Farm GetFarm(int id)
        {
            return _context.Farms.Where(f => f.Id == id).FirstOrDefault();
        }

        public ICollection<Farm> GetFarms()
        {
            return _context.Farms.OrderBy(f => f.Id).ToList();
        }

        public bool CreateFarm(Farm farm)
        {
            _context.Farms.Add(farm);
            return Save();
        }

        public bool UpdateFarm(Farm farm)
        {
            _context.Update(farm);
            return Save();
        }

        public bool DeleteFarm(Farm farm)
        {
            _context.Remove(farm);
            return Save();
        }

    }
}
