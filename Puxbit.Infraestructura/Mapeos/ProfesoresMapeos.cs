using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
    public class ProfesoresMapeos: EntidadBaseMapeo<Profesores>
    {
        public ProfesoresMapeos():base("Profesores")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.PrimerNombre).HasColumnName("PrimerNombre").HasColumnType("varchar").HasMaxLength(25).IsRequired();
            Property(x => x.SegundoNombre).HasColumnName("SegundoNombre").HasColumnType("varchar").HasMaxLength(25).IsRequired();
            Property(x => x.PrimerApellido).HasColumnName("PrimerApellido").HasColumnType("varchar").HasMaxLength(25).IsRequired();
            Property(x => x.SegundoApellido).HasColumnName("SegundoApellido").HasColumnType("varchar").HasMaxLength(25).IsOptional();
            Property(x => x.Identidad).HasColumnName("Identidad").HasColumnType("int").IsRequired();
            Property(x => x.Pasaporte).HasColumnName("Pasaporte").HasColumnType("varchar").HasMaxLength(15).IsOptional();
            Property(x => x.Edad).HasColumnName("Edad").HasColumnType("int").IsRequired();
            Property(x => x.FechaNacimiento).HasColumnName("FechaNacimiento").HasColumnType("datetime").IsRequired();
            Property(x => x.Sexo).HasColumnName("Sexo").HasColumnType("char").IsRequired().HasMaxLength(1);
            Property(x => x.Telefono).HasColumnName("Telefono").HasColumnType("varchar").HasMaxLength(11).IsRequired();
            Property(x => x.Nacionalidad).HasColumnName("Nacionalidad").HasColumnType("varchar").IsRequired();
            Property(x => x.Correo).HasColumnName("Correo").HasColumnType("varchar").HasMaxLength(150).IsRequired();
            Property(x => x.EstadoCivil).HasColumnName("EstadoCivil").HasColumnType("varchar").HasMaxLength(20).IsOptional();
            Property(x => x.NivelEstudio).HasColumnName("NivelEstudio").HasColumnType("varchar").HasMaxLength(50).IsOptional();
            Property(x => x.CampoEstudio).HasColumnName("CampoEstudio").HasColumnType("varchar").HasMaxLength(50).IsOptional();

            HasRequired(x => x.Clase).WithMany(x => x.Profesores).HasForeignKey(x => x.Fk_IdClase);
        }
    }
}
