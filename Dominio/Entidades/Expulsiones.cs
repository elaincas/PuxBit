using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Expulsiones: EntidadBase
    {
        public int Fk_IdAlumno { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaInicioSancion { get; set; }
        public DateTime FechaFinalSancion { get; set; }

        public virtual Alumnos Alumno { get; set; }
    }
    
}
