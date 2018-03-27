using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Calificaciones : EntidadBase
    {
        public int Fk_IdClase { get; set; }
        public int Fk_IdProfesor { get; set; }
        public int Parcial { get; set; }
        public int Fk_IdAlumno { get; set; }
        public Decimal Nota_ip{ get; set; }
        public Decimal Nota_iip { get; set; }
        public Decimal Nota_iiip { get; set; }
        public Decimal Nota_ivp { get; set; }
        public string Estado_ip { get; set; }
        public string Estado_iip { get; set; }
        public string Estado_iiip { get; set; }
        public string Estado_ivp { get; set; }
        public Decimal PromedioClase { get; set; }
        public int BaseCalificacion { get; set; }
        public string Observacion { get; set; }
        public string EstadoClase { get; set; }

        public virtual Clases  Clase{ get; set; }
        public virtual Profesores  Profesor { get; set; }
        public virtual Alumnos Alumno { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";

            if (PromedioClase == 0)
            {
                mensaje = "Favor Ingrese el Promedio de Clase";
                return false;
            }
            if (Nota_ip==0)
            {
                mensaje = "Favor Ingrese Nota del Primer Parcial";
                return false;
            }
            if (Nota_iip == 0)
            {
                mensaje = "Favor Ingrese Nota del Segundo Parcial";
                return false;
            }
            if (Nota_iip == 0)
            {
                mensaje = "Favor Ingrese Nota del Tercer Parcial";
                return false;
            }
            if (Nota_ivp == 0)
            {
                mensaje = "Favor Ingrese Nota del Cuarto Parcial";
                return false;
            }
            if (string.IsNullOrEmpty (EstadoClase))
            {
                mensaje = "Favor Ingrese estado de la Clase";
                return false;
            }
            if (BaseCalificacion == 0)
            {
                mensaje = "Favor Ingrese la base de la Nota";
                return false;
            }

            return true;
        }
    }
}
