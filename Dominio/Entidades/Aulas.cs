using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Aulas: EntidadBase
    {

        public int NumeroAula { get; set; }

        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
     
        public virtual List<ClaseDescripcion> ClasesDescripciones { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";

            if (NumeroAula==0)
            {
                mensaje = "Favor Ingrese el numero de Aula";
                return false;
            }
            if (string.IsNullOrEmpty(Ubicacion))
            {
                mensaje = "Favor Ingrese la Ubbicacion de la Aula";
                return false;
            }
            

            return true;
        }
    }

}
