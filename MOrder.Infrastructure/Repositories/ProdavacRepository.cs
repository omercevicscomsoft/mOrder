using Microsoft.EntityFrameworkCore;
using MOrder.Core.Models2;
using MOrder.Infrastructure.Context;
using MOrder.Infrastructure.DTOs.Output;
using MOrder.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Repositories
{
    internal class ProdavacRepository : BaseRepository<Prodavaci>, IProdavacRepository
    {
        internal ProdavacRepository(DBContext context) : base(context)
        {

        }

        public async Task<OutPotrosac> GetAsync(string userName, string password, bool trackChanges = false)
        {
            return await base.Entity(trackChanges)
                .Select(p => new OutPotrosac()
                {
                    UserName = p.UserName,
                    Password = p.Password,
                    Aktivan = p.Aktivan
                })
                .FirstOrDefaultAsync(d => d.UserName == userName && d.Password == password && d.Aktivan);
        }
    }
}
