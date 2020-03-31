using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.Authentication.Interfaces;
using TravelAgency.Models.UserModel;

namespace TravelAgency.Controllers
{
    public class UserController : Controller
    {
        private readonly IAuthentication _authentication;

        public UserController(IAuthentication authentication)
        {
            _authentication = authentication;
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationData registrationData)
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginData loginData)
        {
            var result = _authentication.Login(loginData.Login, loginData.Password, true);
            if (result==null)
            { 
                ModelState.AddModelError(nameof(loginData.Login), "there is no such combination");
                return View();
            }
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Logout()
        {
           _authentication.Logout();
           return RedirectToAction("Index", "Home");
        }
    }
}