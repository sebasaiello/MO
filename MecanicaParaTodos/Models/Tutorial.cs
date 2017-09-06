using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MecanicaParaTodos.Models
{
    public class Tutorial
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }
        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }
        [Required]
        public string Contenido { get; set; }
        [Required]
        [StringLength(5)]
        public string Dificultad { get; set; }
        [Required]
        [StringLength(10)]
        public string Tiempo { get; set; }
        public DateTime Publicacion { get; set; }
    }
}