using MOrder.Core.Models2;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.Extensions
{
    public static class Model
    {
        public static void Update(this MobileOrders mobileOrder, int status)
        {
            mobileOrder.Status = status;
        }
    }
}
