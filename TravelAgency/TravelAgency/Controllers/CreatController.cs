using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.BusinessLogic.Interfaces;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.Models;
using TravelAgency.Models.Model;

namespace TravelAgency.Controllers
{
    public class CreatController : Controller
    {
        private readonly ITourService _tourService;
        private readonly IHotelService _hotelService;
        private readonly ITourTypeService _tourTypeService;
        private readonly Mapper _mapper;
        public CreatController(ITourService tourService,ITourTypeService tourTypeService, IHotelService hotelService, Mapper mapper)
        {
            _tourTypeService = tourTypeService;
            _hotelService = hotelService;
            _tourService = tourService;
            _mapper = mapper;
        }
        public ActionResult CreatTour()
        {
            var maptourtypes = GetTourTypes();
            var maphotel = GetHotels();
            return View(new DataCreatTourVM
            {
               Hotels=maphotel,
               TourTypes=maptourtypes
               
            });
        }

        [HttpPost]
        public ActionResult CreatTour(TourVM tourVM) {
            if (ModelState.IsValid)
            {
                _tourService.AddTour(_mapper.Map<TourVM,TourBL>(tourVM));

                return View();
            }
            var maptourtypes = GetTourTypes();
            var maphotel = GetHotels();
            return View(new DataCreatTourVM
            {
                Hotels = maphotel,
                TourTypes = maptourtypes

            });

        }

        public IEnumerable<string> GetTourTypes()
        {
            var tourtypes = _tourTypeService.GetTourTypes();
            return tourtypes.Select(x => x.Name);

        }
        public IEnumerable<HotelVM> GetHotels()
        {
            var hotels = _hotelService.GetHotels();
             return _mapper.Map<IEnumerable<HotelBL>, IEnumerable<HotelVM>>(hotels);

        }
    }
}