using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Institucion: EntidadBase
    {
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Licencia { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Encargado { get; set; }
        public virtual Mensajes Mensaje { get; set; }
        public virtual LogErrores  LogEror { get; set; }
    }
}
