using MOrder.Core.Models2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Hubs
{
    public interface ISignalRHub
    {
        Task Update(MobileOrders mobileOrder);
    }
}
