using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Mensajes: EntidadBase
    {
        public int Fk_IdInstitucion { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public int   IdTipoEnvioMensaje { get; set; }
        public DateTime FechaMensaje { get; set; }

        public virtual Institucion Institucion { get; set; }
        public virtual TipoEnvioMensajes  TipoEnvioMensaje { get; set; }

    }
}
