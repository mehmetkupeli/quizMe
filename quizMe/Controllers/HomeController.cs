using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quizMe.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult CreateLogin()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult CreateSurvey()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
