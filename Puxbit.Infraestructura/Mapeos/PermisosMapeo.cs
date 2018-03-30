using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class PermisosMapeo:EntidadBaseMapeo<Permisos>
    {
        public PermisosMapeo():base("Permisos")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.NombrePermiso).HasColumnName("NombrePermiso").HasColumnType("varchar").HasMaxLength(255).IsRequired();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("varhcar").HasMaxLength(255).IsRequired();



        }
    }
}
