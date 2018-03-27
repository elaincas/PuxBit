using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuxBit.Infraestructura.Core
{
    public class BaseUnitOfWork: DbContext, IEntityUnitOfWork
    {
        public BaseUnitOfWork(string cadena): base (cadena)
        {

        }
        public DbSet<TEntidad> ObtenerDbSet<TEntidad>() where TEntidad : class
        {
            return Set<TEntidad>();
        }

        void IUnitOfWork.SaveChanges()
        {
            using (var transaccion = Database.BeginTransaction())
            {
                try
                {
                    SaveChanges();
                    transaccion.Commit();
                }
                catch (Exception ex)

                {
                    transaccion.Rollback();
                }
            }
        }
    }
}
