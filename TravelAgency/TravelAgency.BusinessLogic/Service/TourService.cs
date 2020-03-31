using System.Collections.Generic;
using AutoMapper;
using TravelAgency.BusinessLogic.Interfaces;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Models;
using System.Linq;
using TravelAgency.Models;

namespace TravelAgency.BusinessLogic.Service
{
    public class TourService : ITourService
    {
        private readonly IRepository<Tour> _repository;
        private readonly IRepository<Hotel> _hotelRepository;
        private readonly IRepository<HotelType> _hotelTypeRepository;
        private readonly IRepository<TourType> _tourTypeRepository;
        private readonly Mapper _mapper;

        public TourService(IRepository<Tour> repository, Mapper mapper, IRepository<Hotel> hotelRepository, IRepository<TourType> tourTypeRepository, IRepository<HotelType> hotelTypeRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _hotelRepository = hotelRepository;
            _tourTypeRepository = tourTypeRepository;
            _hotelTypeRepository = hotelTypeRepository;
        }

        public IEnumerable<TourBL> GetTours()
        {
            var tours = _repository.GetAll();
            var mapTours = _mapper.Map<IEnumerable<Tour>, IEnumerable<TourBL>>(tours);
            
            return mapTours;
        }

        public TourBL AddTour(CreateTourBL tourBL)
        {
            var mapTour = _mapper.Map<CreateTourBL, Tour>(tourBL);
            mapTour.TourTypeId = tourBL.TourTypeId;
            mapTour.HotelId = tourBL.HotelId;

            return _mapper.Map<Tour,TourBL>(_repository.Add(mapTour));

        }

        public TourBL GetTour(int id)
        {
            var tour = _repository.GetById(id);
            var mapTour = _mapper.Map<Tour, TourBL>(tour);

            return mapTour;
        }
        
        public IEnumerable<TourBL> GetHotTours()
        {
            var tours = _repository.GetMan(o=>o.Hot);
            var mapHotTours = _mapper.Map<IEnumerable<Tour>, IEnumerable<TourBL>>(tours);
            return mapHotTours;

        }

        public DataCreateTourBL GetDateCreateTour()
        {
            var tourtypes = _mapper.Map<IEnumerable<TourType>, IEnumerable <TourTypeBL>>( _tourTypeRepository.GetAll());
            var hotels = _mapper.Map<IEnumerable<Hotel>, IEnumerable<HotelBL>>(_hotelRepository.GetAll());
            return new DataCreateTourBL()
            {
                TourTypes = tourtypes,
                Hotels = hotels
            };

        }

        public IEnumerable<TourBL> GetSearchTour(DataFilterBL searchBl)
        {
            var tours = _repository.GetMan(o => (o.Price<=searchBl.Price)&& (o.PeopleCount == searchBl.PeopleCount) && (o.TourTypeId == searchBl.TourTypeId) && (o.HotelId == searchBl.HotelTypeId));
            var mapHotTours = _mapper.Map<IEnumerable<Tour>, IEnumerable<TourBL>>(tours);
            return mapHotTours;
        }

        public DataSearchBL GetDataSearch()
        {
            var tourtypes = _mapper.Map<IEnumerable<TourType>, IEnumerable<TourTypeBL>>(_tourTypeRepository.GetAll());
            var hotelType = _mapper.Map<IEnumerable<HotelType>, IEnumerable<HotelTypeBL>>(_hotelTypeRepository.GetAll());
            var peopleCount = _repository.GetAll().Select(x => x.PeopleCount).ToList();
            var minCountPeople = peopleCount.Min();
            var maxCountPeople = peopleCount.Max();
            var priceList = _repository.GetAll().Select(x => x.Price).ToList();
            var minPrice = priceList.Min();
            var maxPrice = priceList.Max();
            return new DataSearchBL()
            {
                TourTypes = tourtypes,
                HotelTypes = hotelType,
                PeopleCountMax = maxCountPeople,
                PeopleCountMin = minCountPeople,
                PriceMax = maxPrice,
                PriceMin = minPrice

            };

        }

        public void DeleteTour(int id)
        {
              _repository.Delete(id);
            
        }
    }
}