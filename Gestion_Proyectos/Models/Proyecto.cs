using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestion_Proyectos.Models
{
    public class Proyecto
    {
        [Key]
        public int ProyectoId { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime? FechInicio { get; set; }

        public DateTime? FechFin { get; set; }
    }
}