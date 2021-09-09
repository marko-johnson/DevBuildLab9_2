using DevBuild_Lab9_2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuild_Lab9_2.Controllers
{
    public class SweepstakesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPage()
        {
            ViewData["FirstName"] = "Marko";
            ViewData["LastName"] = "Johnson";


            return View();
        }

        public IActionResult RegistrationForm()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Congratulations(Contestant _Contestant)
        {
            if (_Contestant.FirstName == null || _Contestant.LastName == null || _Contestant.PhoneNumber == null || _Contestant.Email == null || _Contestant.Password == null)
            {
                ViewData["Message"] = "Please fill in all fields.";
                return View("RegistrationForm");
            }
            else
            {
                return View(_Contestant);
            }

            //ViewData["FirstName"] = firstname;
            //ViewData["LastName"] = lastname;

            
        }


    }
}
