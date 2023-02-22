using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClimaTempoSimples.Models
{
    [Table("PrevisaoClima")]
    public class WeatherForecast
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("CidadeId")]
        public int CityId { get; set; }
        public City City { get; set; }

        [Required]
        [Column("DataPrevisao")]
        public DateTime ForecastDate { get; set; }

        [Required]
        [Column("Clima")]
        [MaxLength(15)]
        public string Climate { get; set; }

        [Required]
        [Column("TemperaturaMinima")]
        public float MinTemperature { get; set; }

        [Required]
        [Column("TemperaturaMaxima")]
        public float MaxTemperature { get; set; }
    }
}