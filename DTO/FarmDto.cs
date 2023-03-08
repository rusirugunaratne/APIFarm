namespace APIFarm.DTO
{
    public class FarmDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Image { get; set; }
        public bool HasBarge { get; set; }
    }
}
