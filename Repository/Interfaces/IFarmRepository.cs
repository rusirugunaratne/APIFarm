using APIFarm.Models;

namespace APIFarm.Repository.Interfaces
{
    public interface IFarmRepository
    {
        ICollection<Farm> GetFarms();
        Farm GetFarm(int id);
        bool CreateFarm(Farm farm);
        bool UpdateFarm(Farm farm);
        bool DeleteFarm(Farm farm);
    }
}
