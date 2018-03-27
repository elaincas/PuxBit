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
        public string Correo { get; set; }
        public string  TelefonoEmergencia { get; set; }
        public string Descripcion { get; set; }
        public string ObsAlergia { get; set; }
        public Boolean Trabaja { get; set; }
        public string NombreTrabajo { get; set; }
        public string NombreTrabjo { get; set; }
        public string LugarTrabajo { get; set; }
        public string EstadoCivil { get; set; }
        public string PadeceEnfermedad { get; set; }

        public virtual List<AsistenciaAlumnos> AsistenciasAlumnos { get; set; }
        public virtual List<Calificaciones> Calificaciones { get; set; }
        public virtual List<Expulsiones> Expulsiones{ get; set; }
        public virtual List<Padres> Padres { get; set; }


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
            if (string.IsNullOrEmpty(TelefonoEmergencia))
            {
                mensaje = "Favor Ingrese un numero de Telefono de  Emergencia";
                return false;
            }
           
            return true;
        }
    }
    
    
}
