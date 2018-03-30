using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Descuentos: EntidadBase
    {
        public string  Descripcion { get; set; }
        public float DescuentoPorcentual { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";

            if (string.IsNullOrEmpty(Descripcion))
            {
                mensaje = "Favor Ingrese la descripcion del Descuento";
                return false;
            }
            if ( DescuentoPorcentual==0)
            {
                mensaje = "Favor Ingrese el descuento en porcentaje";
                return false;
            }
            return true;
        }
    }
}
