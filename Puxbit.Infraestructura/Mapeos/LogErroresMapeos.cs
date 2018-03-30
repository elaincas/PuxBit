using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class LogErroresMapeos:EntidadBaseMapeo<LogErrores>
    {
        public LogErroresMapeos():base("LogErrores")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(255).IsRequired();
            Property(x => x.NombrePantalla).HasColumnName("NombrePantalla").HasColumnType("varchar").HasMaxLength(150).IsRequired();
            Property(x => x.VersionSistema).HasColumnName("VersionSistema").HasColumnType("varchar").HasMaxLength(150).IsRequired();
            Property(x => x.Evento).HasColumnName("Evento").HasColumnType("varchar").HasMaxLength(255).IsRequired();

            HasRequired(x => x.Institucion).WithMany(x => x.LogErrores).HasForeignKey(x => x.Fk_Institucion);
        }
    }
}
