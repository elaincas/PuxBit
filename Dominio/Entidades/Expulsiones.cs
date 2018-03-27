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
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";


            if (string.IsNullOrEmpty(Motivo))
            {
                mensaje = "Favor Ingrese el motivo";
                return false;
            }
            if (FechaInicioSancion==null)
            {
                mensaje = "Favor Ingrese la Fecha de Inicio ";
                return false;
            }
            if (FechaFinalSancion==null)
            {
                mensaje = "Favor Ingrese la fecha final";
                return false;
            }
             
            return true;
        }
    }
    
}
