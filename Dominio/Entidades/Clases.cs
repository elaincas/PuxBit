﻿using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Clases: EntidadBase
    {
        public string NombreClase { get; set; }
        public virtual Calificaiones Calificacion { get; set; }
    }
}
