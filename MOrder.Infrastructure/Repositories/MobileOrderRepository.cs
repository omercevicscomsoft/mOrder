using MOrder.Core.Models2;
using MOrder.Infrastructure.Context;
using MOrder.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.Repositories
{
    internal class MobileOrderRepository : BaseRepository<MobileOrders>, IMobileOrderRepository
    {
        internal MobileOrderRepository(DBContext context) : base(context)
        {

        }
        public new MobileOrders Create(MobileOrders mobileOrder)
        {
            return base.Create(mobileOrder);
        }
    }
}
