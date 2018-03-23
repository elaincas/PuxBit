using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class AsistenciaAlumnos
    {
        public int Fk_IdAlumno { get; set; }
        public int Fk_IdProfesor { get; set; }
        public Boolean Dias { get; set; }
        public Boolean Lunes { get; set; }
        public Boolean Martes { get; set; }
        public Boolean Miercoles { get; set; }
        public Boolean Jueves { get; set; }
        public Boolean Viernes { get; set; }

        public Boolean Sabado { get; set; }
        public Boolean Domingo { get; set; }
    }
}
