using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
    public class AulasMapeos:EntidadBaseMapeo<Aulas>

    {
        public AulasMapeos():base("Aulas")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.NumeroAula).HasColumnName("NumeroAula").HasColumnType("int").IsRequired();
            Property(x => x.Ubicacion).HasColumnName("Ubicacion").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(100).IsRequired();

        }
    }
}
