using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuxBit.Infraestructura.Core
{
    public interface IEntityUnitOfWork: IUnitOfWork
    {
        DbSet<TEntidad> ObtenerDbSet<TEntidad>() where TEntidad : class;

    }
}
