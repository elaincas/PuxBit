using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuxBit.Aplicacion.DTOS
{
    public class Respuesta
    {
        public RespuestaTipo TipoRespuesta { get; set; }
        public string Mensaje { get; set; }
        public Respuesta()
        {
            Mensaje = "Éxito";
        }
    }
}
