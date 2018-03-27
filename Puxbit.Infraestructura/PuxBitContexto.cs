using Dominio.Entidades;
using Puxbit.Infraestructura.Mapeos;
using PuxBit.Infraestructura.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puxbit.Infraestructura
{
    public class PuxBitContexto : BaseUnitOfWork, IUnitOfWork
    {
        public PuxBitContexto() : base("cadena")
        { }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<AsistenciaAlumnos> AsistenciaAlumnos { get; set; } //PENDIENTE REVISAR
        public DbSet<Aulas> Aulas { get; set; }
        public DbSet<Calificaciones> Calificaiones { get; set; } //Pendiente
        public DbSet<ClaseDescripcion> ClaseDescripcion { get; set; }
        public DbSet<Jornadas> Jornadas { get; set; }
        public DbSet<Clases> Clases { get; set; }
        public DbSet<Descuentos> Descuentos { get; set; }
        public DbSet<Eventos> Eventos { get; set; } //Pendiente

        public DbSet<Expulsiones> Expulsiones { get; set; } //Pendiete

        public DbSet<Grados> Grados { get; set; }
        public DbSet<LogErrores> LogErroes { get; set; }
        public DbSet<Institucion> Institucion { get; set; }
        public DbSet<Mensajes> Mensajes { get; set; }
        public DbSet<Padres> Padres { get; set; }
        public DbSet<Pantalla> Pantallla { get; set; } //Pendiente
        public DbSet<Perfiles> Perfiles { get; set; } //Pendiete
        public DbSet<PerfilesPermisos> PerfilesPermiso { get; set; }//Pendiente
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<Secciones> Secciones { get; set; }
        public DbSet<TipoClase> TipoClase { get; set; }
        public DbSet<TipoEnvioMensajes> TipoEnvioMensajes { get; set; } //Pendiente

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new JornadasMapeos());
            modelBuilder.Configurations.Add(new AlumnosMapeos());
            modelBuilder.Configurations.Add(new AulasMapeos());
            modelBuilder.Configurations.Add(new ClasesDescripcionMapeos());
            modelBuilder.Configurations.Add(new ClasesMapeo());
            modelBuilder.Configurations.Add(new DescuentosMapeo());
            modelBuilder.Configurations.Add(new GradosMapeos());
            modelBuilder.Configurations.Add(new InstitucionesMapeos());
            modelBuilder.Configurations.Add(new LogErroresMapeos());
            modelBuilder.Configurations.Add(new MensajesMapeos());
            modelBuilder.Configurations.Add(new PadresMapeos());
            modelBuilder.Configurations.Add(new ProfesoresMapeos());
            modelBuilder.Configurations.Add(new SeccionesMapeos());
            modelBuilder.Configurations.Add(new TipoClasesMapeos());
            ;


        }


    }
}
