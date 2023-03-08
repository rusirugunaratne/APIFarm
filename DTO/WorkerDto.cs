namespace APIFarm.DTO
{
    public class WorkerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int FarmId { get; set; }
        public string Position { get; set; }
        public string CertifiedUntil { get; set; }
        public string Image { get; set; }
    }
}
