using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
  public  class CalificacionesMapeos:EntidadBaseMapeo<Calificaciones>
    {
        public CalificacionesMapeos():base("Calificaciones")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.PromedioClase).HasColumnName("PromedioClase").HasColumnType("double").IsRequired();
            Property(x => x.Nota_ip).HasColumnName("Nota_ip").HasColumnType("double").IsRequired();
            Property(x => x.Nota_iip).HasColumnName("Nota_iip").HasColumnType("double").IsRequired();
            Property(x => x.Nota_iiip).HasColumnName("Nota_iiip").HasColumnType("double").IsRequired();
            Property(x => x.Nota_ivp).HasColumnName("Nota_ivp").HasColumnType("double").IsRequired();
            Property(x => x.Estado_ip).HasColumnName("Estado_ip").HasColumnType("string").IsRequired();
            Property(x => x.Estado_iip).HasColumnName("Estado_iip").HasColumnType("string").IsRequired();
            Property(x => x.Estado_iiip).HasColumnName("Estado_iiip").HasColumnType("string").IsRequired();
            Property(x => x.Estado_ivp).HasColumnName("Estado_ivp").HasColumnType("string").IsRequired();
            Property(x => x.EstadoClase).HasColumnName("EstadoClase").HasColumnType("boolean").IsRequired();
            Property(x => x.BaseCalificacion).HasColumnName("baseCalificacion").HasColumnType("int").IsRequired();
            Property(x => x.Observacion).HasColumnName("Observacion").HasColumnType("string").IsOptional();

            HasRequired(x => x.Clase).WithMany(x => x.Calificaciones).HasForeignKey(x => x.Fk_IdClase);
            HasRequired(x => x.Profesor).WithMany(x => x.Calificaciones).HasForeignKey(x => x.Fk_IdProfesor);
            HasRequired(x => x.Alumno).WithMany(x => x.Calificaciones).HasForeignKey(x => x.Fk_IdAlumno);
        }
    }
}
