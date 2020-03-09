using AutoMapper;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.BusinessLogic.Infrastructure
{
    public class GlobalProfile:Profile
    {
        public GlobalProfile()
        {
            CreateMap<HotelType, HotelTypeBL>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}