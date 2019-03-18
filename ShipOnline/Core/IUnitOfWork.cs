using System;
using ShipOnline.Core.Repositories;

namespace ShipOnline.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companies { get; }
        IShipRepository Ships { get; }
        int Complete();
    }
}