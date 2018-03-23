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
        public string CostoMensual { get; set; }

    }
}
