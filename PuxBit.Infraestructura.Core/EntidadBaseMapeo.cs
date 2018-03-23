using Dominio.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuxBit.Infraestructura.Core
{
    public class EntidadBaseMapeo<TEntidad>: EntityTypeConfiguration<TEntidad> where TEntidad : EntidadBase
    {
        public EntidadBaseMapeo(string tablaNombre)
        {
            //                                      CAMPO                   TIPO               
            Property(x => x.FechaCrea).HasColumnName("").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaModifica).HasColumnName("").HasColumnType("datetime").IsOptional();
            Property(x => x.UsuarioCrea).HasColumnName("").HasColumnType("int").IsRequired();
            Property(x => x.UsuarioModifica).HasColumnName("").HasColumnType("int").IsOptional();

        }
    }
}
