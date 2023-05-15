using AutoMapper;
using Staff.Service.Schemas;
using Kadro = Staff.Data.Domains;

namespace Staff.Service.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Kadro.Staff, StaffResponse>();
            CreateMap<StaffResponse, Kadro.Staff>();

            CreateMap<Kadro.Staff, StaffRequest>();
            CreateMap<StaffRequest, Kadro.Staff>();
        }
    }
}