﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieRegustration.Models;

namespace MovieRegustration.Controllers
{
    public class MovieController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }

 

}
