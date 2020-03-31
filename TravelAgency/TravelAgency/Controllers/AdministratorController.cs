using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using TravelAgency.BusinessLogic.Interfaces;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.Models.Model;

namespace TravelAgency.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly ITourService _tourService;
        private readonly Mapper _mapper;
        public AdministratorController(ITourService tourService, Mapper mapper)
        {
            _tourService = tourService;
            _mapper = mapper;
        }

        public ActionResult Administrator()
        {
            return View();
        }

        public ActionResult DeleteTour()
        {
            var countTour = _tourService.GetTours().Count();

            return View(new DataDeleteTourVM
            { CountTour = countTour });
        }

        [HttpPost]
        public ActionResult DeleteTour(DataDeleteTourVM deleteTourVm)
        {

            if (ModelState.IsValid)
            {
                _tourService.DeleteTour(deleteTourVm.Id);
            }
            var countTour = _tourService.GetTours().Count();
            return View(new DataDeleteTourVM
            { CountTour = countTour });
        }

        public ActionResult ModificationTour()
        {
            var countTour = _tourService.GetTours().Count();

            return View(new ModificationTourVM()
            { CountTour = countTour });
        }

        [HttpPost]
        public ActionResult ModificationTour(ModificationTourVM modificationTourVm)
        {

            if (modificationTourVm.Id > 0)
            {
                var tour = _mapper.Map<TourBL, TourVM>(_tourService.GetTour(modificationTourVm.Id));

                if (tour != null)
                {
                    var dataCreateTour = _tourService.GetDateCreateTour();
                    var mapData = _mapper.Map<DataCreateTourBL, DataCreatTourVM>(dataCreateTour);
                    return View("UpdateTour", new ModificationTourVM()
                    {
                        TourVm = tour,
                        DataCreated = mapData,
                        Id = modificationTourVm.Id
                    });
                }

            }

            var countTour = _tourService.GetTours().Count();

            return View(new ModificationTourVM()
            { CountTour = countTour });
        }
        
        [HttpPost]
        public ActionResult UpdateTour(ModificationTourVM modificationTourVm)
        {
            var tour = _mapper.Map<CreateTourVM, CreateTourBL>(modificationTourVm.DataCreated.Tour);
            tour.Id = modificationTourVm.Id;
            _tourService.Update(tour);

            return RedirectToAction("MoreDetailsATour", "Home", tour);
        }
    }
}