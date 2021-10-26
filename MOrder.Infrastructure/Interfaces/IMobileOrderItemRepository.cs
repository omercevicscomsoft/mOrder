using MOrder.Core.Models2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Interfaces
{
    public interface IMobileOrderItemRepository
    {
        MobileOrderItems Create(MobileOrderItems mobileOrderItems);
        void Delete(MobileOrderItems orderItem);
    }
}
