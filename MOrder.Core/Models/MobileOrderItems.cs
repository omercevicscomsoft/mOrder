using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class MobileOrderItems
    {
        public int Id { get; set; }
        public int MobileOrderId { get; set; }
        public string SifraArtikla { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public string SifraGrupeArtikala { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal KolicinaNaTalonu { get; set; }

        public virtual MobileOrders MobileOrder { get; set; }
        public virtual Artikli SifraArtiklaNavigation { get; set; }
    }
}
