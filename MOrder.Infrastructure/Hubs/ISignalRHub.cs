using MOrder.Core.Models2;
using MOrder.Infrastructure.DTOs.Output;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Hubs
{
    public interface ISignalRHub
    {
        Task Update(OutMobileOrder mobileOrder);
    }
}
