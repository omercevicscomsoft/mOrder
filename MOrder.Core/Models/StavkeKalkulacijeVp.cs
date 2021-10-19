using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkeKalkulacijeVp
    {
        public StavkeKalkulacijeVp()
        {
            KalkulacijeZavisniTroskovi = new HashSet<KalkulacijeZavisniTroskovi>();
        }

        public int Id { get; set; }
        public string SifraOj { get; set; }
        public string BrojKalkulacije { get; set; }
        public string SifraArtikla { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal Marza { get; set; }
        public decimal Rabat1 { get; set; }
        public decimal Rabat2 { get; set; }
        public decimal ZavisniTrosak { get; set; }
        public decimal Akciza { get; set; }
        public string BrojSerije { get; set; }
        public string BrojKontrolePrveSerije { get; set; }
        public string BrojKontroleSvakeSerije { get; set; }
        public DateTime? RokTrajanja { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid Guid { get; set; }

        public virtual KalkulacijeVp KalkulacijeVp { get; set; }
        public virtual Artikli SifraArtiklaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual ICollection<KalkulacijeZavisniTroskovi> KalkulacijeZavisniTroskovi { get; set; }
    }
}
