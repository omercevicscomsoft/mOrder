using MOrder.Core.Models2;
using MOrder.Infrastructure.DTOs.Input;
using MOrder.Infrastructure.DTOs.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOrder.Infrastructure.Utils.Mapping
{
    public static class MobileOrderMapper
    {
        public static MobileOrders Map(InMobileOrderDTO mobOrder)
        {
            return new MobileOrders
            {
                Id = 0,
                DodatniOpis = mobOrder.DodatniOpis,
                UserNameProdavaca = mobOrder.UserNameProdavaca,
                StolId = mobOrder.StolId,
                Status = 0,
                AddedDate = DateTime.Now,
                DatumIvrijeme = DateTime.Now,
                ModifiedBy = "",
                ModifiedDate = DateTime.Now
            };
        }

        public static OutMobileOrder Map(MobileOrders order)
        {
            return new OutMobileOrder
            {
                Id = order.Id,
                DatumIvrijeme = order.DatumIvrijeme,
                DodatniOpis = order.DodatniOpis,
                Status = (Models.Status)order.Status,
                StolId = order.StolId,
                UserNameProdavaca = order.UserNameProdavaca,
                MobileOrderItems = order.MobileOrderItems.Select(x=> MobileOrderItemMapper.Map(x))
            };
        }
    }
}
