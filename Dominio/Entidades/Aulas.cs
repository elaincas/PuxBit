using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Aulas: EntidadBase
    {

        public int NumeroAula { get; set; }

        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
      
    }
}
