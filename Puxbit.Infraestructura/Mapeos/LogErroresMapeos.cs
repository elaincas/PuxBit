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
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("string").IsRequired();
            Property(x => x.NombrePantalla).HasColumnName("NombrePantalla").HasColumnType("string").IsRequired();
            Property(x => x.VesionSistema).HasColumnName("VersionSistema").HasColumnType("string").IsRequired();
            Property(x => x.Evento).HasColumnName("Evento").HasColumnType("string").IsRequired();

            HasRequired(x => x.Institucion).WithMany(x => x.LogErrores).HasForeignKey(x => x.Fk_Institucion);
        }
    }
}
