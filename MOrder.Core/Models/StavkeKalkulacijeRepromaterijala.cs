using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkeKalkulacijeRepromaterijala
    {
        public StavkeKalkulacijeRepromaterijala()
        {
            KalkulacijeRepromaterijalaZavisniTroskovi = new HashSet<KalkulacijeRepromaterijalaZavisniTroskovi>();
        }

        public int Id { get; set; }
        public string SkladisteId { get; set; }
        public string BrojKalkulacije { get; set; }
        public string RepromaterijalId { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal Rabat1 { get; set; }
        public decimal Rabat2 { get; set; }
        public decimal ZavisniTrosak { get; set; }
        public decimal Akciza { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid Guid { get; set; }

        public virtual KalkulacijeRepromaterijala KalkulacijeRepromaterijala { get; set; }
        public virtual Repromaterijal Repromaterijal { get; set; }
        public virtual OrganizacioneJedinice Skladiste { get; set; }
        public virtual ICollection<KalkulacijeRepromaterijalaZavisniTroskovi> KalkulacijeRepromaterijalaZavisniTroskovi { get; set; }
    }
}
