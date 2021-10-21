using MOrder.Core.Models2;
using MOrder.Infrastructure.Context;
using MOrder.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Repositories
{
    internal class MobileOrderItemRepository : BaseRepository<MobileOrderItems>, IMobileOrderItemRepository
    {
        internal MobileOrderItemRepository(DBContext context) : base(context)
        {

        }
        public new MobileOrderItems Create(MobileOrderItems mobileOrderItem)
        {
            return base.Create(mobileOrderItem);
        }

    }
}
