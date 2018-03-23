using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class PerfilesPermisos: EntidadBase
    {
        public int Fk_IdPerfil { get; set; }
        public int Fk_IdPermisos { get; set; }
        public int Fk_IdPantalla { get; set; }
        public Boolean Estado { get; set; }

        public virtual  List<Perfiles>Perfiles { get; set; }
    }
}
