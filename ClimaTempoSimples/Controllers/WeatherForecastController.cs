﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClimaTempoSimples.Controllers
{
    public class WeatherForecastController : Controller
    {
        // GET: WeatherForecast
        public ActionResult Index()
        {
            return View();
        }
    }
}