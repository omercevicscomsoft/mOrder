using MOrder.Core.Models2;
using MOrder.Infrastructure.DTOs.Input;
using MOrder.Infrastructure.DTOs.Output;
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
                Id = mobOrderItem.Id,
                MobileOrderId = mobOrderItem.MobileOrderId,
                SifraArtikla = mobOrderItem.SifraArtikla,
                SifraGrupeArtikala = mobOrderItem.SifraGrupeArtikala,
                Cijena = mobOrderItem.Cijena,
                Kolicina = mobOrderItem.Kolicina,
                AddedDate = DateTime.Now,
                ModifiedBy = "",
                ModifiedDate = DateTime.Now,
                KolicinaNaTalonu = mobOrderItem.KolicinaNaTalonu
            };
        }

        public static OutMobileOrderItem Map(MobileOrderItems mobOrderItem)
        {
            return new OutMobileOrderItem
            {
                Id = mobOrderItem.Id,
                Cijena = mobOrderItem.Cijena,
                Kolicina = mobOrderItem.Kolicina,
                MobileOrderId = mobOrderItem.MobileOrderId,
                SifraArtikla = mobOrderItem.SifraArtikla,
                SifraGrupeArtikala = mobOrderItem.SifraGrupeArtikala,
                SifraArtiklaNavigation = ArtiklMapper.Map(mobOrderItem.SifraArtiklaNavigation),
                KolicinaNaTalonu = mobOrderItem.KolicinaNaTalonu
            };
        }
    }
}
