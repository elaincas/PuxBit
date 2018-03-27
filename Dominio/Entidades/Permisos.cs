using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Permisos: EntidadBase
    {
        public string NombrePermiso { get; set; }
        public string Descripcion { get; set; }
        public virtual List<PerfilesPermisos> PerfilesPermisos { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";


            if (string.IsNullOrEmpty(Descripcion))
            {
                mensaje = "Favor Ingrese la Descripcion  ";
                return false;
            }
            if (string.IsNullOrEmpty(NombrePermiso))
            {
                mensaje = "Favor Ingrese el Nombre";
                return false;
            }
             
            return true;
        }
    }
}
