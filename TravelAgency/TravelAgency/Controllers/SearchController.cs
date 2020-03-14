using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.BusinessLogic.Interfaces;

namespace TravelAgency.Controllers
{
    public class SearchController : Controller
    {
        private readonly ITourService _tourService;
        private readonly Mapper _mapper;
        public SearchController(ITourService tourService, Mapper mapper)
        {
            _tourService = tourService;
            _mapper = mapper;
        }
        public ActionResult SearchTour()
        {
            return View();
        }
    }
}