using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
    public  class ClasesDescripcionMapeos:EntidadBaseMapeo<ClaseDescripcion>
    {
        public ClasesDescripcionMapeos():base("ClaseDescripcion")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Dia).HasColumnName("Dias").HasColumnType("string").IsRequired();
            Property(x => x.HoraClase).HasColumnName("HoraClase").HasColumnType("datetime").IsRequired();
            

        }

    }
}
