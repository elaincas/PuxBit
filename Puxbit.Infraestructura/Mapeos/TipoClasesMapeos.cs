﻿using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class TipoClasesMapeos:EntidadBaseMapeo<TipoClase>
    {
        public TipoClasesMapeos():base("TipoClase")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(25).IsRequired();
        }
    }
}
