using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class GradosMapeos :EntidadBaseMapeo<Grados>
    {
        public GradosMapeos():base("Grados")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("string").IsRequired();
            Property(x => x.CostoMensual).HasColumnName("CostoMensual").HasColumnType("double").IsRequired();
        }
    }
}
