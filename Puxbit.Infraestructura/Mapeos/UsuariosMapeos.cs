using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class UsuariosMapeos:EntidadBaseMapeo<Usuarios>
    {
        public UsuariosMapeos():base("Usuarios")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();
            Property(x => x.Usuario).HasColumnName("Usuario").HasColumnType("varchar").IsRequired();
            Property(x => x.Password).HasColumnName("Password").HasColumnType("string").IsRequired();
            Property(x => x.PistaPassword).HasColumnName("PistaPassword").HasColumnType("string").IsRequired();
            Property(x => x.PrimerNombre).HasColumnName("PrimerNombre").HasColumnType("string").IsRequired();
            Property(x => x.SegundoNombre).HasColumnName("SegundoNombre").HasColumnType("string").IsRequired();

            HasRequired(x => x.Perfil).WithMany(x => x.Usuarios).HasForeignKey(x => x.Fk_IdPerfil);


        }
    }
}
