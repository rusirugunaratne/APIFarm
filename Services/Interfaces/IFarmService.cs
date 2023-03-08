using APIFarm.Models;

namespace APIFarm.Services.Interfaces
{
    public interface IFarmService
    {
        ICollection<Farm> GetFarms();
        Farm GetFarm(int id);
        bool CreateFarm(Farm farm);
        bool UpdateFarm(Farm farm);
        bool DeleteFarm(int id);
    }
}
