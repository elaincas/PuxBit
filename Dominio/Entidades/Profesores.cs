using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Profesores: EntidadBase
    {
        public int Fk_IdClase { get; set; }
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
        public string Nacionalidad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string EstadoCivil { get; set; }
        public string NivelEstudio { get; set; }
        public string CampoEstudio { get; set; }

        public virtual Clases Clase { get; set; }

        public virtual List<AsistenciaAlumnos> AsistenciasAlumnos{ get; set; }
        public virtual List<Calificaciones> Calificaciones { get; set; }
        public virtual List<ClaseDescripcion> ClasesDescripciones { get; set; }

    }
}
