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
            Property(x => x.PrimerNombre).HasColumnName("PrimerNombre").HasColumnType("string").IsRequired();
            Property(x => x.SegundoNombre).HasColumnName("SegundoNombre").HasColumnType("string").IsRequired();
            Property(x => x.PrimerApellido).HasColumnName("PrimerApellido").HasColumnType("string").IsRequired();
            Property(x => x.SegundoApellido).HasColumnName("SegundoApellido").HasColumnType("string").IsOptional();
            Property(x => x.Identidad).HasColumnName("Identidad").HasColumnType("int").IsRequired();
            Property(x => x.Pasaporte).HasColumnName("Pasporte").HasColumnType("string").IsRequired();
            Property(x => x.Edad).HasColumnName("Edad").HasColumnType("int").IsRequired();
            Property(x => x.FechaNacimiento).HasColumnName("FechaNacimiento").HasColumnType("datetime").IsRequired();
            Property(x => x.Sexo).HasColumnName("Sexo").HasColumnType("char").IsRequired();
            Property(x => x.Telefono).HasColumnName("Telefono").HasColumnType("string").IsRequired();
            Property(x => x.Nacionalidad).HasColumnName("Nacionalidad").HasColumnType("string").IsRequired();
            Property(x => x.Correo).HasColumnName("Correo").HasColumnType("string").IsRequired();
            Property(x => x.Telefono2).HasColumnName("Telefono2").HasColumnType("string").IsRequired();
            Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("string").IsOptional();
            Property(x => x.Ocupacion).HasColumnName("Ocupacion").HasColumnType("string").IsOptional();
            Property(x => x.Trabaja).HasColumnName("Trabaja").HasColumnType("boolean").IsRequired();
            Property(x => x.NombreTrabajo).HasColumnName("NombreTrabajo").HasColumnType("string").IsOptional();
            Property(x => x.LugarTrabajo).HasColumnName("LugarTrabajo").HasColumnType("string").IsOptional();
            Property(x => x.EstadoCivil).HasColumnName("EstadoCivil").HasColumnType("string").IsOptional();
            Property(x => x.Parentesco).HasColumnName("Parentesco").HasColumnType("string").IsOptional();
            Property(x => x.DireccionHogar).HasColumnName("DireccionHogar").HasColumnType("string").IsOptional();
            Property(x => x.User).HasColumnName("User").HasColumnType("string").IsOptional();
            Property(x => x.Password).HasColumnName("Password").HasColumnType("string").IsOptional();

            HasRequired(x => x.Alumno).WithMany(x => x.Padres).HasForeignKey(x => x.Fk_IdAlumno);
        }
    }
}
