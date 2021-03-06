using MOrder.Core.Models2;
using MOrder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Interfaces
{
    public interface IMobileOrderRepository
    {
        MobileOrders Create(MobileOrders mobileOrder);
        Task<MobileOrders> GetAsync(int id, bool trackChanges = false);
        Task<MobileOrders> GetAsyncRoot(int id, bool trackChanges = false);
        Task<IEnumerable<MobileOrders>> GetAsync(bool trackChanges = false);
        Task<IEnumerable<MobileOrders>> GetAsync(string userNameProdavaca, bool trackChanges = false);
        MobileOrders Update(MobileOrders mobileOrder);

        void Delete(MobileOrders mobileOrder);
    }
}
