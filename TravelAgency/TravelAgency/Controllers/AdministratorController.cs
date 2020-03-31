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
            return View();
        }
    }
}