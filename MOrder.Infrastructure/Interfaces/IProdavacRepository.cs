using MOrder.Infrastructure.DTOs.Output;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Interfaces
{
    public interface IProdavacRepository
    {
        Task<OutPotrosac> GetAsync(string userName, string password, bool trackChanges = false);
    }
}
