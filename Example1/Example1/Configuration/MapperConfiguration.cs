using AutoMapper;
using Example1.Data;
using Example1.Models;

namespace Example1.Configuration
{
    public class MapperConfiguration : Profile
    {

        public MapperConfiguration()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<HotelDto,Hotels>().ReverseMap();
        }
    }
}
