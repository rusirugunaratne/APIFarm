using APIFarm.Models;
using APIFarm.Repository.Interfaces;
using APIFarm.Services.Interfaces;

namespace APIFarm.Services
{
    public class FarmService : IFarmService
    {
        private readonly IFarmRepository _farmRepository;

        public FarmService(IFarmRepository farmRepository)
        {
            _farmRepository = farmRepository;
        }

        public bool CreateFarm(Farm farm)
        {
            return _farmRepository.CreateFarm(farm);
        }

        public bool DeleteFarm(int id)
        {
            return _farmRepository.DeleteFarm(_farmRepository.GetFarm(id));
        }

        public Farm GetFarm(int id)
        {
            return _farmRepository.GetFarm(id);
        }

        public ICollection<Farm> GetFarms()
        {
            return _farmRepository.GetFarms();
        }

        public bool UpdateFarm(Farm farm)
        {
            return _farmRepository.UpdateFarm(farm);
        }
    }
}
