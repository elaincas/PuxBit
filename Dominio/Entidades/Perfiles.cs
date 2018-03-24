﻿using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Perfiles: EntidadBase
    {
        public string NombrePerfil { get; set; }
        public string Descripcion { get; set; }

        public virtual List<PerfilesPermisos> PerfilesPermisos { get; set; }
        public virtual List<Usuarios> Usuarios { get; set; }

    }
}
