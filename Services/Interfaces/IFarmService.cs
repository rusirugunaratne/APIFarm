using APIFarm.Models;

namespace APIFarm.Services.Interfaces
{
    public interface IFarmService
    {
        ICollection<Farm> GetFarms();
        Farm GetFarm(int id);
        bool CreateFarm(Farm farm);
        bool UpdateFarm(int id, Farm farm);
        bool DeleteFarm(int id);
    }
}
