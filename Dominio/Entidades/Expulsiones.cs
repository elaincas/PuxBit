﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class Expulsiones
    {
        public int Fk_IdAlumno { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaInicioSancion { get; set; }
        public DateTime FechaFinalSancion { get; set; }
    }
    
}