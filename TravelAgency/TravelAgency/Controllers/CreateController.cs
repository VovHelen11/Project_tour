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
    public class CreateController : Controller
    {
        private readonly ITourService _tourService;
        private readonly Mapper _mapper;
        public CreateController(ITourService tourService, Mapper mapper)
        {
            _tourService = tourService;
            _mapper = mapper;
        }
        public ActionResult CreateTour()
        {
            var dataCreateTour = _tourService.GetDateCreateTour();
            var mapData = _mapper.Map<DataCreateTourBL, DataCreatTourVM>(dataCreateTour);
            return View(mapData);
            
        }

        [HttpPost]
        public ActionResult CreateTour(DataCreatTourVM createTourVm) {

            if (ModelState.IsValid)
            {
               var tour= _tourService.AddTour(_mapper.Map<CreateTourVM,CreateTourBL>(createTourVm.Tour));

                return RedirectToAction("MoreDetailsATour","Home", tour);
            }

            var dataCreateTour = _tourService.GetDateCreateTour();
            var mapData = _mapper.Map<DataCreateTourBL, DataCreatTourVM>(dataCreateTour);
            return View(mapData);

        }

        
    }
}