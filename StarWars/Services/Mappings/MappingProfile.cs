using AutoMapper;
using StarWars.Context.Models;
using StarWars.Services.Dto;

namespace StarWars.Services.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<StarsShip, StarsShipDto>();
            CreateMap<StarsShipDto, StarsShip>();

            CreateMap<People, PeopleDto>();
            CreateMap<PeopleDto, People>();

            CreateMap<Page<People>, PageDto<PeopleDto>>()
                .ForMember(dest => dest.MaxPage, opt => opt.MapFrom(src => src.MaxPage))
                .ForMember(dest => dest.PageCollection, opt => opt.MapFrom(src => src.PageCollecion));

            CreateMap<Page<StarsShip>, PageDto<StarsShipDto>>()
                .ForMember(dest => dest.MaxPage, opt => opt.MapFrom(src => src.MaxPage))
                .ForMember(dest => dest.PageCollection, opt => opt.MapFrom(src => src.PageCollecion));

        }
    }
}
