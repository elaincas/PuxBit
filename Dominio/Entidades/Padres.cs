using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Padres: EntidadBase
    {
        public string PrimerNombre { get; set; }
        public string Fk_IdAlumno { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Identidad { get; set; }
        public string Pasaporte { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Nacionalidad { get; set; }
        public string Correo { get; set; }
        public string Descripcion { get; set; }
        public Boolean Trabaja { get; set; }
        public string NombreTrabajo { get; set; }
        public string LugarTrabajo { get; set; }
        public string EstadoCivil { get; set; }
        public string Parentesco { get; set; }
        public string Ocupacion { get; set; }
        public string DireccionHogar { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public virtual Alumnos Alumno { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
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
            if (string.IsNullOrEmpty(SegundoApellido))
            {
                mensaje = "Favor Ingrese Segundo  Apellido";
                return false;
            }
            if (Identidad==0)
            {
                mensaje = "Favor Ingrese la Identidad";
                return false;
            }
            if (Edad == 0)
            {
                mensaje = "Favor Ingrese la Edad";
                return false;
            }
            if (FechaNacimiento==null)
            {
                mensaje = "Favor Ingrese la Fecha de Nacimiento";
                return false;
            }
            if (string.IsNullOrEmpty(Sexo))
            {
                mensaje = "Favor Ingrese el Sexo";
                return false;
            }
            if (string.IsNullOrEmpty(Telefono))
            {
                mensaje = "Favor Ingrese el Telefono";
                return false;
            }
            if (string.IsNullOrEmpty(Nacionalidad))
            {
                mensaje = "Favor Ingrese la Nacionalidad";
                return false;
            }
            if (string.IsNullOrEmpty(Parentesco))
            {
                mensaje = "Favor Ingrese el parentesco";
                return false;
            }
            if (string.IsNullOrEmpty(User))
            {
                mensaje = "Favor Ingrese el usuario";
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                mensaje = "Favor Ingrese la Contranseña";
                return false;
            }
            return true;
        }




    }
}
