using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PuxBit.Infraestructura.Core
{
    
        public class RepositorioBase<TEntidad> : IRepositorioBase<TEntidad> where TEntidad : class
        {
            private readonly IEntityUnitOfWork _unitOfWork;
            public DbSet<TEntidad> Tabla;

            public IUnitOfWork UnitofWork
            {
                get
                {
                    return _unitOfWork;
                }
            }

            public RepositorioBase(IEntityUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
                Tabla = unitOfWork.ObtenerDbSet<TEntidad>();
            }

            public void Agregar(TEntidad entidad)
            {
                Tabla.Add(entidad);
            }

            public void AgregarRango(List<TEntidad> entidad)
            {
                Tabla.AddRange(entidad);
            }

            public TEntidad FirstOfDefault(Expression<Func<TEntidad, bool>> filtro)
            {
                return Tabla.FirstOrDefault(filtro);
            }

            public TEntidad ObtenerPorId(int id)
            {
                return Tabla.Find(id);
            }

            public List<TEntidad> ObtenerTodos()
            {
                return Tabla.ToList();
            }

            public List<TEntidad> Where(Expression<Func<TEntidad, bool>> filtro)
            {
                return Tabla.Where(filtro).ToList();
            }

            public IQueryable<TEntidad> AsQueryable()
            {
                return Tabla.AsQueryable();
            }

        public List<TEntidad> Where(Expression<Func<TEntidad, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public TEntidad FirstOfDefault(Expression<Func<TEntidad, bool>> filtro)
        {
            throw new NotImplementedException();
        }
    }
 
}
