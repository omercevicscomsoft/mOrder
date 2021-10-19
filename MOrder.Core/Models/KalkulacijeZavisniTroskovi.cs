using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class KalkulacijeZavisniTroskovi
    {
        public int Id { get; set; }
        public int KalkulacijaItemId { get; set; }
        public string SifraZavisnogTroska { get; set; }
        public decimal IznosZavisnogTroska { get; set; }
        public decimal ProcenatZavisnogTroska { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SifraOj { get; set; }
        public string BrojKalkulacije { get; set; }
        public string SifraArtikla { get; set; }
        public Guid Guid { get; set; }

        public virtual Artikli SifraArtiklaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual ZavisniTroskovi SifraZavisnogTroskaNavigation { get; set; }
        public virtual StavkeKalkulacijeVp StavkeKalkulacijeVp { get; set; }
    }
}
