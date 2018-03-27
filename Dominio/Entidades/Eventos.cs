using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
   public  class Eventos:EntidadBase
    {
        public string Descripcion { get; set; }
        public string Titulo { get; set; }
        public string Ubicacion { get; set; }
        public DateTime FechaEvento { get; set; }
        public DateTime HoraEvento { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";


            if (string.IsNullOrEmpty(Descripcion))
            {
                mensaje = "Favor Ingrese la descripcion del evento";
                return false;
            }
            if (string.IsNullOrEmpty(Titulo))
            {
                mensaje = "Favor Ingrese el titutlo del evento";
                return false;
            }
            if (string.IsNullOrEmpty(Ubicacion))
            {
                mensaje = "Favor Ingrese la ubicacion del evento";
                return false;
            }
            if (FechaEvento==null)
            {
                mensaje = "Favor Ingrese la Fecha del evento";
                return false;
            }
            if (HoraEvento==null)
            {
                mensaje = "Favor Ingrese la Hora del evento";
                return false;
            }
            return true;
        }
    }
}
