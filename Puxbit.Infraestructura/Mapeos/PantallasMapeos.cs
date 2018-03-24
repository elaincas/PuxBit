using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class PantallasMapeos:EntidadBaseMapeo<Pantalla>
    {
        public PantallasMapeos():base("Pantallas")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Nombre).HasColumnName("Nombre").HasColumnType("string").IsRequired();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("string").IsRequired();
            Property(x => x.Estado).HasColumnName("Estado").HasColumnType("string").IsRequired();
        }
    }
}
