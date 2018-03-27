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
            Property(x => x.Dias).HasColumnName("Dias").HasColumnType("boolean").IsRequired();
            Property(x => x.Lunes).HasColumnName("Lunes").HasColumnType("boolean").IsOptional();
            Property(x => x.Martes).HasColumnName("Martes").HasColumnType("boolean").IsOptional();
            Property(x => x.Miercoles).HasColumnName("Miercoles").HasColumnType("boolean").IsOptional();
            Property(x => x.Jueves).HasColumnName("Jueves").HasColumnType("boolean").IsOptional();
            Property(x => x.Viernes).HasColumnName("Viernes").HasColumnType("boolean").IsOptional();
            Property(x => x.Sabado).HasColumnName("Sabado").HasColumnType("boolean").IsOptional();
            Property(x => x.Domingo).HasColumnName("Domingo").HasColumnType("boolean").IsOptional();

            HasRequired(x => x.Alumno).WithMany(x => x.AsistenciasAlumnos).HasForeignKey(x => x.Fk_IdAlumno);
            HasRequired(x => x.Profesor).WithMany(x => x.AsistenciasAlumnos).HasForeignKey(x => x.Fk_IdProfesor);

        }
    }
}
