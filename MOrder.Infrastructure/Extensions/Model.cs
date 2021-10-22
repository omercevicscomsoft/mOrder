using MOrder.Core.Models2;
using MOrder.Infrastructure.DTOs.Input;
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

        public static void Update(this MobileOrders mobileOrder, InMobileOrderDTO mobileOrderDTO)
        {
            mobileOrder.StolId = mobileOrderDTO.StolId;
            mobileOrder.DodatniOpis = mobileOrderDTO.DodatniOpis;
        }
    }
}
