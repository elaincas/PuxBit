using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class TipoClase: EntidadBase
    {
        public string Descripcion { get; set; }
        public virtual List<ClaseDescripcion> ClasesDescripciones { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";


            if (string.IsNullOrEmpty(Descripcion))
            {
                mensaje = "Favor Ingrese la Descripcion  ";
                return false;
            }
            return true;
        }
    }
}
