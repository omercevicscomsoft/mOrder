using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class KalkulacijeRepromaterijalaZavisniTroskovi
    {
        public int Id { get; set; }
        public int KalkulacijaItemId { get; set; }
        public string SifraZavisnogTroska { get; set; }
        public decimal IznosZavisnogTroska { get; set; }
        public decimal ProcenatZavisnogTroska { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SkladisteId { get; set; }
        public string BrojKalkulacije { get; set; }
        public string RepromaterijalId { get; set; }
        public Guid Guid { get; set; }

        public virtual Repromaterijal Repromaterijal { get; set; }
        public virtual ZavisniTroskovi SifraZavisnogTroskaNavigation { get; set; }
        public virtual OrganizacioneJedinice Skladiste { get; set; }
        public virtual StavkeKalkulacijeRepromaterijala StavkeKalkulacijeRepromaterijala { get; set; }
    }
}
