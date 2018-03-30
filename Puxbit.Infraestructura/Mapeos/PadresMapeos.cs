using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
    public class PadresMapeos:EntidadBaseMapeo<Padres>
    {
        public PadresMapeos():base("Padres")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.PrimerNombre).HasColumnName("PrimerNombre").HasColumnType("varchar").HasMaxLength(25).IsRequired();
            Property(x => x.SegundoNombre).HasColumnName("SegundoNombre").HasColumnType("varchar").HasMaxLength(25).IsRequired();
            Property(x => x.PrimerApellido).HasColumnName("PrimerApellido").HasColumnType("varchar").HasMaxLength(25).IsRequired();
            Property(x => x.SegundoApellido).HasColumnName("SegundoApellido").HasColumnType("varchar").HasMaxLength(25).IsOptional();
            Property(x => x.Identidad).HasColumnName("Identidad").HasColumnType("int").IsRequired();
            Property(x => x.Pasaporte).HasColumnName("Pasporte").HasColumnType("varchar").HasMaxLength(15).IsOptional();
            Property(x => x.Edad).HasColumnName("Edad").HasColumnType("int").IsRequired();
            Property(x => x.FechaNacimiento).HasColumnName("FechaNacimiento").HasColumnType("datetime").IsRequired();
            Property(x => x.Sexo).HasColumnName("Sexo").HasColumnType("char").HasMaxLength(1).IsRequired();
            Property(x => x.Telefono).HasColumnName("Telefono").HasColumnType("varchar").HasMaxLength(11).IsRequired();
            Property(x => x.Nacionalidad).HasColumnName("Nacionalidad").HasColumnType("varchar").HasMaxLength(30).IsRequired();
            Property(x => x.Correo).HasColumnName("Correo").HasColumnType("varchar").HasMaxLength(150).IsOptional();
            Property(x => x.Telefono2).HasColumnName("Telefono2").HasColumnType("varchar").HasMaxLength(11).IsOptional();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(100).IsOptional();
            Property(x => x.Ocupacion).HasColumnName("Ocupacion").HasColumnType("varchar").HasMaxLength(50).IsOptional();
            Property(x => x.Trabaja).HasColumnName("Trabaja").HasColumnType("boolean").IsOptional();
            Property(x => x.NombreTrabajo).HasColumnName("NombreTrabajo").HasColumnType("varchar").HasMaxLength(50).IsOptional();
            Property(x => x.LugarTrabajo).HasColumnName("LugarTrabajo").HasColumnType("varchar").HasMaxLength(250).IsOptional();
            Property(x => x.EstadoCivil).HasColumnName("EstadoCivil").HasColumnType("varchar").HasMaxLength(20).IsOptional();
            Property(x => x.Parentesco).HasColumnName("Parentesco").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            Property(x => x.DireccionHogar).HasColumnName("DireccionHogar").HasColumnType("varchar").HasMaxLength(250).IsOptional();
            Property(x => x.User).HasColumnName("User").HasColumnType("varchar").HasMaxLength(20).IsOptional();
            Property(x => x.Password).HasColumnName("Password").HasColumnType("varchar").HasMaxLength(20).IsOptional();

            HasRequired(x => x.Alumno).WithMany(x => x.Padres).HasForeignKey(x => x.Fk_IdAlumno);
        }
    }
}
