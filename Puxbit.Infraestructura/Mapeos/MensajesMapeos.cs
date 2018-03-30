using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class MensajesMapeos:EntidadBaseMapeo<Mensajes>
    {
        public MensajesMapeos():base("Mensajes")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Titulo).HasColumnName("Titulo").HasColumnType("varchar").HasMaxLength(255).IsRequired();
            Property(x => x.Contenido).HasColumnName("Contenido").HasColumnType("varchar").HasMaxLength(255).IsRequired();
            Property(x => x.FechaCrea).HasColumnName("FechaCrea").HasColumnType("datetime").IsRequired();

            HasRequired(x => x.Institucion).WithMany(x => x.Mensajes).HasForeignKey(x => x.Fk_IdInstitucion);
            HasRequired(x => x.TipoEnvioMensaje).WithMany(x => x.Mensajes).HasForeignKey(x => x.IdTipoEnvioMensaje);

        }
    }
}
