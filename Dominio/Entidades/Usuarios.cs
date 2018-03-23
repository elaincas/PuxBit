using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class Usuarios
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string PistaPassword { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public int Fk_IdPerfil { get; set; }

    }
}
