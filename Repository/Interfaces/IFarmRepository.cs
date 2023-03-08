using APIFarm.Models;

namespace APIFarm.Repository.Interfaces
{
    public interface IFarmRepository
    {
        ICollection<Farm> GetFarms();
        Farm GetFarm(int id);
    }
}
