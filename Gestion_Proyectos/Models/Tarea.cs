using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestion_Proyectos.Models
{
    public class Tarea
    {
        [Key]
        public int TareaId { get; set; }

        public string Descripcion { get; set; }

        public DateTime? FchLimite { get; set; }

        public string Estado { get; set; }

        public int ProyectoId { get; set; }

        public virtual Proyecto Proyecto { get; set; }
    }
}