using System;
using System.Collections.Generic;
using System.Text;

namespace Vikekh.Cabinet.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
