using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Calificaiones : EntidadBase
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


    }
}
