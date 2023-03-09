using APIFarm.DTO;
using APIFarm.Models;
using AutoMapper;

namespace APIFarm.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Farm, FarmDto>().ReverseMap();
            CreateMap<Worker, WorkerDto>().ReverseMap();
        }
    }
}
