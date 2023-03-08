using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIFarm.Models
{
    public class Farm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Image { get; set; }
        public bool HasBarge { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
