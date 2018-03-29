using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Grados: EntidadBase
    {
        public string Descripcion { get; set; }
        public Decimal CostoMensual { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";


            if (string.IsNullOrEmpty(Descripcion))
            {
                mensaje = "Favor Ingrese la descripcion del evento";
                return false;
            }
            if (CostoMensual==0)
            {
                mensaje = "Favor Ingrese el Costo";
                return false;
            }
             
            return true;
        }
    }
}
