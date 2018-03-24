using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class ClaseDescripcion: EntidadBase
    {
        public int Fk_IdClase { get; set; }
        public int Fk_IdProfesor { get; set; }
        public string Dia { get; set; }
        public DateTime HoraClase { get; set; }
        public int Fk_IdTipoClase { get; set; }
        public int Fk_IdJornada { get; set; }
        public int Fk_IdSeccion { get; set; }
        public int Fk_IdAula { get; set; }

        public virtual Clases Clase { get; set; }
        public virtual Profesores Profesor { get; set; }
        public virtual TipoClase TipoClase { get; set; }
        public virtual Jornadas Jornada { get; set; }
        public virtual Secciones Seccion { get; set; }
        public virtual Aulas Aula { get; set; }


    }
}
