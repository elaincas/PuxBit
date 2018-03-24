﻿using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{

   public class ClasesMapeos: EntidadBaseMapeo<Clases>
    {
        public ClasesMapeos():base("Clases")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.NombreClase).HasColumnName("NombreClase").HasColumnType("string").IsRequired();


        }
    }
}
