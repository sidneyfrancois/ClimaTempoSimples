using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempoSimples.Models
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public DateTime ForecastDate { get; set; }
        public string Climate { get; set; }
        public float MinTemperature { get; set; }
        public float MaxTemperature { get; set; }
    }
}