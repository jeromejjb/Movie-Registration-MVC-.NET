using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegustration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegustration.Controllers
{
    public class HomeController : Controller
    {


      MovieDbContext movieDb = new MovieDbContext();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegistrationForm()
        {

            return View();
        }
        public IActionResult Result(Movie inputMovie)
        {
            
            return View(inputMovie);
            

        }
       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
