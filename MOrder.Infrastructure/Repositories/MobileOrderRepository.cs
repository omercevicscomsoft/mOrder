using Microsoft.EntityFrameworkCore;
using MOrder.Core.Models2;
using MOrder.Infrastructure.Context;
using MOrder.Infrastructure.Interfaces;
using MOrder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Repositories
{
    internal class MobileOrderRepository : BaseRepository<MobileOrders>, IMobileOrderRepository
    {
        internal MobileOrderRepository(DBContext context) : base(context)
        {

        }

        public new MobileOrders Update(MobileOrders mobileOrder)
        {
            return base.Update(mobileOrder);
        }

        public new MobileOrders Create(MobileOrders mobileOrder)
        {
            return base.Create(mobileOrder);
        }

        public async Task<IEnumerable<MobileOrders>> GetAsync(bool trackChanges = false)
        {
            return await base.Entity(trackChanges).Include(x=>x.MobileOrderItems).ThenInclude(y=>y.SifraArtiklaNavigation).Where(x=>x.DatumIvrijeme>DateTime.Now.AddHours(-12) && !x.Fakturisano).ToListAsync();
        }

        public async Task<MobileOrders> GetAsync(int id, bool trackChanges = false)
        {
            return await base.Entity(trackChanges).Include(x => x.MobileOrderItems).ThenInclude(y => y.SifraArtiklaNavigation).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<MobileOrders> GetAsyncRoot(int id, bool trackChanges = false)
        {
            return await base.Entity(trackChanges).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<MobileOrders>> GetAsync(string userNameProdavaca, bool trackChanges = false)
        {
            return await base.Entity(trackChanges).Include(x => x.MobileOrderItems).ThenInclude(y => y.SifraArtiklaNavigation).Where(x => x.UserNameProdavaca == userNameProdavaca && x.DatumIvrijeme > DateTime.Now.AddHours(-12) && !x.Fakturisano).ToListAsync();
        }

        public new void Delete(MobileOrders mobileOrder)
        {
            base.Delete(mobileOrder);
        }
    }
}
