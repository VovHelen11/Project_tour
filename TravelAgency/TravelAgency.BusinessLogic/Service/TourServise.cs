using System.Collections.Generic;
using AutoMapper;
using TravelAgency.BusinessLogic.Interfaces;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Models;
using System.Linq;

namespace TravelAgency.BusinessLogic.Service
{
    public class TourServise : ITourService
    {
        private readonly IRepository<Tour> _repository;
        private readonly Mapper _mapper;

        public TourServise(IRepository<Tour> repository, Mapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<TourBL> GetTours()
        {
            var tours = _repository.GetAll();
            var mapTours = _mapper.Map<IEnumerable<Tour>, IEnumerable<TourBL>>(tours);
            
            return mapTours;
        }

        public void AddTour(TourBL tourBL)
        {
            _repository.Add(_mapper.Map<TourBL, Tour>(tourBL));
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
    }
}