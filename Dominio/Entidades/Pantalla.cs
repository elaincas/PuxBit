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
        public Boolean Estado { get; set; }
        public virtual List<PerfilesPermisos> PerfilesPermisos { get; set; }

    }
}
