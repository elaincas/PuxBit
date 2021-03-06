﻿using Dominio.Entidades;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura.Mapeos
{
   public class PerfilesPermisosMapeos:EntidadBaseMapeo<PerfilesPermisos>
    {
        public PerfilesPermisosMapeos():base("PerfilesPermisos")
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasColumnName("ID").HasColumnType("int").IsRequired();

            HasRequired(x => x.Perfil).WithMany(x=>x.PerfilesPermisos).HasForeignKey(x => x.Fk_IdPerfil);
            HasRequired(x => x.Permiso).WithMany(x=>x.PerfilesPermisos).HasForeignKey(x => x.Fk_IdPermisos);
            HasRequired(x => x.Pantalla).WithMany(x => x.PerfilesPermisos).HasForeignKey(x => x.Fk_IdPantalla);

        }
    }
}
