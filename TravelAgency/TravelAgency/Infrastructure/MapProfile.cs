using AutoMapper;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.Models;
using TravelAgency.Models.Model;

namespace TravelAgency.Infrastructure
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            

            CreateMap<HotelAddressBL, HotelAddressVM>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(srt => srt.City))
                .ForMember(dest => dest.Street, opt => opt.MapFrom(srt => srt.Street))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(srt => srt.Country));     

            CreateMap<HotelBL, HotelVM>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.HotelAddress, opt => opt.MapFrom(src => src.HotelAddress))
                .ForMember(dest => dest.HotelType, opt => opt.MapFrom(src => src.HotelType));

            CreateMap<TourVM, TourBL>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ArrivalDate, opt => opt.MapFrom(src => src.ArrivalDate))
                .ForMember(dest => dest.DepartureData, opt => opt.MapFrom(src => src.DepartureData))
                .ForMember(dest => dest.PeopleCount, opt => opt.MapFrom(src => src.PeopleCount))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.TourType, opt => opt.MapFrom(src => src.TourType))
                .ForMember(dest => dest.Hotel, opt => opt.MapFrom(src => src.Hotel));
            CreateMap<HotelAddressVM, HotelAddressBL>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(srt => srt.City))
                .ForMember(dest => dest.Street, opt => opt.MapFrom(srt => srt.Street))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(srt => srt.Country));

            CreateMap<HotelVM, HotelBL>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.HotelAddress, opt => opt.MapFrom(src => src.HotelAddress))
                .ForMember(dest => dest.HotelType, opt => opt.MapFrom(src => src.HotelType));

            CreateMap<TourBL, TourVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ArrivalDate, opt => opt.MapFrom(src => src.ArrivalDate))
                .ForMember(dest => dest.DepartureData, opt => opt.MapFrom(src => src.DepartureData))
                .ForMember(dest => dest.PeopleCount, opt => opt.MapFrom(src => src.PeopleCount))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.TourType, opt => opt.MapFrom(src => src.TourType))
                .ForMember(dest => dest.Hotel, opt => opt.MapFrom(src => src.Hotel));
        }
    }
}