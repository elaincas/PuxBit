using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
  public  class AsistenciaAlumnosMapeos:EntidadBaseMapeo<AsistenciaAlumnos>
    {
        public AsistenciaAlumnosMapeos():base("AsistenciaAlumnos")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Dias).HasColumnName("Dias").HasColumnType("bit").IsRequired();
            Property(x => x.Lunes).HasColumnName("Lunes").HasColumnType("bit").IsOptional();
            Property(x => x.Martes).HasColumnName("Martes").HasColumnType("bit").IsOptional();
            Property(x => x.Miercoles).HasColumnName("Miercoles").HasColumnType("bit").IsOptional();
            Property(x => x.Jueves).HasColumnName("Jueves").HasColumnType("bit").IsOptional();
            Property(x => x.Viernes).HasColumnName("Viernes").HasColumnType("bit").IsOptional();
            Property(x => x.Sabado).HasColumnName("Sabado").HasColumnType("bit").IsOptional();
            Property(x => x.Domingo).HasColumnName("Domingo").HasColumnType("bit").IsOptional();


        }
    }
}
