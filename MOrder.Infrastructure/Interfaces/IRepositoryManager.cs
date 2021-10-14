using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Interfaces
{
    public interface IRepositoryManager
    {
        Task SaveAsync();
    }
}
