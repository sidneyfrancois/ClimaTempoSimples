using ClimaTempoSimples.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClimaTempoSimples.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly AppDataContext _contextDB;

        public WeatherForecastController(AppDataContext context)
        {
            _contextDB = context;
        }

        public ActionResult Index()
        {
            var test = _contextDB.States.ToList();

            return View();
        }
    }
}