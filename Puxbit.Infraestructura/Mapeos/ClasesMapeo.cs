using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
    public class ClasesMapeo: EntidadBaseMapeo<Clases>
    {
        //Constructor de la tabla de Clases
        public ClasesMapeo():base("Clases")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.NombreClase).HasColumnName("NombreClase").HasColumnType("varchar").HasMaxLength(50).IsRequired();
        }
    }
}
