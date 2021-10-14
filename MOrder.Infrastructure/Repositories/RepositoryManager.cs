using MOrder.Infrastructure.Context;
using MOrder.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DBContext _context;

        public RepositoryManager(DBContext context)
        {
            this._context = context;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
