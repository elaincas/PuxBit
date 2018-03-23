using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.Entidades
{
    public class EntidadBase
    {
        public int UsuarioCrea { get; set; }
        public int UsuarioModifica { get; set; }
        public DateTime FechaCrea { get; set; }
        public DateTime FechaModifica { get; set; }
        public Boolean EsActivo { get; set; }
        public int ID { get; set; }
        public EntidadBase()
        {
            FechaCrea = DateTime.Now;
            EsActivo = true;
        }
    }
}
