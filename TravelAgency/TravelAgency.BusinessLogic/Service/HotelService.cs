
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TravelAgency.BusinessLogic.Interfaces;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.BusinessLogic.Service
{
    public class HotelService:IHotelService
    {
        
      private readonly IRepository<HotelType> _repository;
      private readonly Mapper _mapper;

      public HotelService(IRepository<HotelType> repository, Mapper mapper)
      {
          _repository = repository;
          _mapper = mapper;
      }

      public IEnumerable<HotelTypeBL> SetHotelType()
      {
          var hotels = _repository.GetAll();
          var mapHotels = _mapper.Map<IEnumerable<HotelType>, IEnumerable<HotelTypeBL>>(hotels);

          return mapHotels;
      }
    }
}