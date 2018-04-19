using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuxBit.Aplicacion
{
   public class GuardarExpulsionesdto
    {
        public string Motivo { get; set; }
        public DateTime FechaInicioSancion { get; set; }
        public DateTime FechaFinalSancion { get; set; }
    }
}
