using MOrder.Core.Models2;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.Interfaces
{
    public interface IMobileOrderRepository
    {
        MobileOrders Create(MobileOrders mobileOrder);
    }
}
