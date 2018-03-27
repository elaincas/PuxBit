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

        public virtual List<LogErrores> LogErrores { get; set; }
        public virtual List<Mensajes> Mensajes { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";


            if (string.IsNullOrEmpty(Nombre))
            {
                mensaje = "Favor Ingrese el Nombre";
                return false;
            }
            if (string.IsNullOrEmpty(Ubicacion))
            {
                mensaje = "Favor Ingrese la Ubicacion";
                return false;
            }
            if (string.IsNullOrEmpty(Licencia))
            {
                mensaje = "Favor Ingrese la Licencia";
                return false;
            }
            if (string.IsNullOrEmpty(Correo))
            {
                mensaje = "Favor Ingrese el Correo";
                return false;
            }
            if (string.IsNullOrEmpty(Telefono))
            {
                mensaje = "Favor Ingrese el Telefono";
                return false;
            }
            if (string.IsNullOrEmpty(Encargado))
            {
                mensaje = "Favor Ingrese el Nombre de Encargado";
                return false;
            }
            return true;
        }
    }
}
