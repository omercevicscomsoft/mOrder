using Microsoft.AspNetCore.SignalR;
using MOrder.Core.Models2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Hubs
{
    public class SignalRHub : Hub<ISignalRHub>
    {
        public async Task UpdateOrder(MobileOrders mobileOrder)
        {
            await Clients.All.Update(mobileOrder);
        }
    }
}
