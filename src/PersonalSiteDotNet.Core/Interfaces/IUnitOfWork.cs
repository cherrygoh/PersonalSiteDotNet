using PersonalSiteDotNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalSiteDotNet.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
