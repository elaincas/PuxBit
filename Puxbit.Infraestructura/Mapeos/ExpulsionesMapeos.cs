using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class ExpulsionesMapeos:EntidadBaseMapeo<Expulsiones>
    {
        public ExpulsionesMapeos():base("Expulsiones")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Motivo).HasColumnName("Motivo").HasColumnType("string").IsRequired();
            Property(x => x.FechaInicioSancion).HasColumnName("FechaInicioSancion").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaFinalSancion).HasColumnName("FechaFinalSancion").HasColumnType("datetime").IsRequired();

            HasRequired(x => x.Alumno).WithMany(x => x.Expulsiones).HasForeignKey(x => x.Fk_IdAlumno);

        }
    }
}
