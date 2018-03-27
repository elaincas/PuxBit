using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
    public class EventosMapeos:EntidadBaseMapeo<Eventos>
    {
        public EventosMapeos():base("Eventos")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("string").IsRequired();
            Property(x => x.Titulo).HasColumnName("Titulo").HasColumnType("string").IsRequired();
            Property(x => x.Ubicacion).HasColumnName("Ubicacion").HasColumnType("string").IsRequired();
            Property(x => x.FechaEvento).HasColumnName("FechaEvento").HasColumnType("datetime").IsRequired();
            Property(x => x.HoraEvento).HasColumnName("HoraEvento").HasColumnType("datetime").IsRequired();
        }
    }
}
