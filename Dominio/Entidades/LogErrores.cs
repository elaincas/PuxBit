using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class LogErrores: EntidadBase
    {
        public string Descripcion { get; set; }
        public string NombrePantalla { get; set; }
        public string VesionSistema { get; set; }
        public string Evento { get; set; }
        public int Fk_Institucion { get; set; }

        public virtual Institucion Institucion { get; set; }
    }
}
