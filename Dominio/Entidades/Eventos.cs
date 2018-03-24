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
    }
}
