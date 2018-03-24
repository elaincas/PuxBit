using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
    public  class ClasesDescripcionMapeos:EntidadBaseMapeo<ClaseDescripcion>
    {
        public ClasesDescripcionMapeos():base("ClaseDescripcion")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Dia).HasColumnName("Dias").HasColumnType("string").IsRequired();
            Property(x => x.HoraClase).HasColumnName("HoraClase").HasColumnType("datetime").IsRequired();

            HasRequired(x => x.Clase).WithMany(x => x.ClasesDescripciones).HasForeignKey(x => x.Fk_IdClase);
            HasRequired(x => x.Profesor).WithMany(x => x.ClasesDescripciones).HasForeignKey(x => x.Fk_IdProfesor);
            HasRequired(x => x.TipoClase).WithMany(x => x.ClasesDescripciones).HasForeignKey(x => x.Fk_IdTipoClase);
            HasRequired(x => x.Jornada).WithMany(x => x.ClasesDescripciones).HasForeignKey(x => x.Fk_IdTipoClase);
            HasRequired(x => x.Seccion).WithMany(x => x.ClasesDescripciones).HasForeignKey(x => x.Fk_IdSeccion);
            HasRequired(x => x.Aula).WithMany(x => x.ClasesDescripciones).HasForeignKey(x => x.Fk_IdAula);

        }

    }
}
