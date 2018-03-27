using System;

namespace PuxBit.Infraestructura.Core
{
    public interface IUnitOfWork: IDisposable
    {
        void SaveChanges();
    }
}