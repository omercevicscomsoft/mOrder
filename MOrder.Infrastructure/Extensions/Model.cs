using MOrder.Core.Models2;
using MOrder.Infrastructure.DTOs.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.Extensions
{
    public static class Model
    {
        public static void Update(this MobileOrders mobileOrder, int status, bool fakturisano)
        {
            mobileOrder.Status = status;
            mobileOrder.Fakturisano = fakturisano;
        }

        public static void Update(this MobileOrders mobileOrder, bool piceIsporuceno)
        {
            mobileOrder.PiceIsporuceno = piceIsporuceno;
        }

        public static void Update(this MobileOrders mobileOrder, InMobileOrderDTO mobileOrderDTO)
        {
            mobileOrder.StolId = mobileOrderDTO.StolId;
            mobileOrder.DodatniOpis = mobileOrderDTO.DodatniOpis;
        }
    }
}
