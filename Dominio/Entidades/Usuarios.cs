using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuarios: EntidadBase
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string PistaPassword { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public int Fk_IdPerfil { get; set; }

        public virtual Perfiles Perfil { get; set; }
        public Boolean esEntidadValida(out string mensaje)
        {
            mensaje = "OK";


            if (string.IsNullOrEmpty(Usuario))
            {
                mensaje = "Favor Ingrese el Usuario  ";
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                mensaje = "Favor Ingrese la Contraseña";
                return false;
            }

            if (string.IsNullOrEmpty(PistaPassword))
            {
                mensaje = "Favor Ingrese la Pista";
                return false;
            }

            if (string.IsNullOrEmpty(PrimerNombre))
            {
                mensaje = "Favor Ingrese el Segundo Nombre";
                return false;
            }

            if (string.IsNullOrEmpty(SegundoNombre))
            {
                mensaje = "Favor Ingrese la Segundo Nombre";
                return false;
            }
            return true;
        }
    }
}
