using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class PerfilesPermisos
    {
        public int Fk_IdPerfilPermisos { get; set; }
        public int Fk_IdPerfil { get; set; }
        public int Fk_IdPermisos { get; set; }
        public int Fk_IdPantalla { get; set; }
        public Boolean Estado { get; set; }
    }
}
