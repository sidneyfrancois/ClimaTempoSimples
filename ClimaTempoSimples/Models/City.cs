using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClimaTempoSimples.Models
{
    [Table("Cidade")]
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Nome")]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [Column("EstadoId")]
        public int StateId { get; set; }
        public State State { get; set; }
    }
}