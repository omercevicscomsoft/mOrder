using MOrder.Core.Models2;
using MOrder.Infrastructure.DTOs.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.Utils.Mapping
{
    public static class MobileOrderItemMapper
    {
        public static MobileOrderItems Map(InMobileOrderItemDTO mobOrderItem)
        {
            return new MobileOrderItems
            {
                Id = 0,
                MobileOrderId = mobOrderItem.MobileOrderId,
                SifraArtikla = mobOrderItem.SifraArtikla,
                SifraGrupeArtikala = mobOrderItem.SifraGrupeArtikala,
                Cijena = mobOrderItem.Cijena,
                Kolicina = mobOrderItem.Kolicina,
                AddedDate = DateTime.Now,
                ModifiedBy = "",
                ModifiedDate = DateTime.Now
            };
        }
    }
}
