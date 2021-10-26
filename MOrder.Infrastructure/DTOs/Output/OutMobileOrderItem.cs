using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.DTOs.Output
{
    public class OutMobileOrderItem
    {
        public int Id { get; set; }
        public int MobileOrderId { get; set; }
        public decimal Cijena { get; set; }
        public decimal Kolicina { get; set; }
        public string SifraArtikla { get; set; }
        public string SifraGrupeArtikala { get; set; }
        public OutArtikl SifraArtiklaNavigation { get; set; }
        public decimal KolicinaNaTalonu { get; set; }
    }
}
