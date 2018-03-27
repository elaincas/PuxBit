using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Pantalla: EntidadBase
    {
        public string Nombre  { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public virtual List<PerfilesPermisos> PerfilesPermisos { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";


            if (string.IsNullOrEmpty(Nombre))
            {
                mensaje = "Favor Ingrese el nombre";
                return false;
            }
            if (string.IsNullOrEmpty(Descripcion))
            {
                mensaje = "Favor Ingrese la descripcion";
                return false;
            }
            if (string.IsNullOrEmpty(Estado))
            {
                mensaje = "Favor Ingrese la ubicacion del evento";
                return false;
            } 
            return true;
        }
    }
}
