using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClimaTempoSimples.Models
{
    [Table("Estado")]
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Nome")]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(2)]
        public string UF { get; set; }
    }
}