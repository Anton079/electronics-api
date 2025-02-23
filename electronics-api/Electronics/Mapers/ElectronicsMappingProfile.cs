using AutoMapper;
using electronics_api.Electronics.Dtos;
using electronics_api.Electronics.Models;


namespace electronics_api.Electronics.Mapers
{
    public class ElectronicsMappingProfile:Profile
    {
        public ElectronicsMappingProfile()
        {
            CreateMap<ElectronicRequest, Electronic>();
            CreateMap<Electronic, ElectronicResponse>();
        }
    }
}
