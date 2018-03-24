using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class InstitucionesMapeos:EntidadBaseMapeo<Institucion>
    {
        public InstitucionesMapeos():base("Institucion")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Nombre).HasColumnName("Nombre").HasColumnType("string").IsRequired();
            Property(x => x.Ubicacion).HasColumnName("Ubicacion").HasColumnType("string").IsRequired();
            Property(x => x.Licencia).HasColumnName("Licencia").HasColumnType("string").IsRequired();
            Property(x => x.Correo).HasColumnName("Correo").HasColumnType("string").IsRequired();
            Property(x => x.Telefono).HasColumnName("Telefono").HasColumnType("string").IsRequired();
            Property(x => x.Encargado).HasColumnName("Encargado").HasColumnType("string").IsRequired();

        }
        
    }
}
