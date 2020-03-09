using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.BusinessLogic.Interfaces;

namespace TravelAgency.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHotelService _hotelService;
        public HomeController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }
        // GET: Home
        public ActionResult Index()
        {
            _hotelService.SetHotelType();

            return View();
        }

        public ActionResult ReserveATour()
        {
            return View();
        }
    }
}