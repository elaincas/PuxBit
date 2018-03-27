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
        public string VersionSistema { get; set; }
        public string Evento { get; set; }
        public int Fk_Institucion { get; set; }

        public virtual Institucion Institucion { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";


            if (string.IsNullOrEmpty(Descripcion))
            {
                mensaje = "Favor Ingrese el Nombre";
                return false;
            }
            if (string.IsNullOrEmpty(NombrePantalla))
            {
                mensaje = "Favor Ingrese la Ubicacion";
                return false;
            }
            if (string.IsNullOrEmpty(VersionSistema))
            {
                mensaje = "Favor Ingrese la Licencia";
                return false;
            }
            if (string.IsNullOrEmpty(Evento))
            {
                mensaje = "Favor Ingrese el Correo";
                return false;
            }
             
            return true;
        }
    }
}
