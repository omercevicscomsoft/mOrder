
using Microsoft.AspNetCore.SignalR;
using MOrder.Core.Models2;
using MOrder.Infrastructure.DTOs.Output;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Hubs
{
    public class SignalRHub : Hub<ISignalRHub>
    {
        public async Task UpdateOrder(OutMobileOrder mobileOrder)
        {
            await Clients.All.Update(mobileOrder);
        }

        public async Task IspisiFiskalniRacun(int id, string nacinPlacanja)
        {
            await Clients.All.IspisiFiskalniRacun(id, nacinPlacanja);
        }
    }
}
