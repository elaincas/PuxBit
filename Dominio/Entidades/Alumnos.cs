using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Alumnos : EntidadBase
    {
        public int IdAlumno { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Identidad { get; set; }
        public string Pasaporte { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string TipoSangre { get; set; }
        public string Telefono { get; set; }
        public string Nacionalidad { get; set; }


        public Boolean esEntidadValida(out string mensaje) {
            mensaje = "OK";

            if (string.IsNullOrEmpty(PrimerNombre))
            {
                mensaje = "Favor Ingrese Primer Nombre";
                return false;
            }
            if (string.IsNullOrEmpty(SegundoNombre))
            {
                mensaje = "Favor Ingrese Segundo Nombre";
                return false;
            }
            if (string.IsNullOrEmpty(PrimerApellido))
            {
                mensaje = "Favor Ingrese Primer Apellido";
                return false;
            }
            return true;
        }
    }
    
    
}
