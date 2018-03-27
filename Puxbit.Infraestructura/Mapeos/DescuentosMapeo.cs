using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class DescuentosMapeo:EntidadBaseMapeo<Descuentos>

    {
        public DescuentosMapeo():base("Descuentos")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("string").IsRequired();
            Property(x => x.DescuentoPorcentual).HasColumnName("DescuentoPorcentual").HasColumnType("double").IsRequired();
        }
    }
}
