using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PuxBit.Infraestructura.Core
{
     
        public interface IRepositorioBase<TEntidad> where TEntidad : class
        {
            void Agregar(TEntidad entidad);
            void AgregarRango(List<TEntidad> entidad);

            TEntidad ObtenerPorId(int id);
            List<TEntidad> ObtenerTodos();
            List<TEntidad> Where(Expression<Func<TEntidad, bool>> filtro);
            TEntidad FirstOfDefault(Expression<Func<TEntidad, bool>> filtro);
            IQueryable<TEntidad> AsQueryable();
            IUnitOfWork UnitofWork { get; }
        }
     
}
