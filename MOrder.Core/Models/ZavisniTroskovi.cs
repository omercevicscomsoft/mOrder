using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class ZavisniTroskovi
    {
        public ZavisniTroskovi()
        {
            KalkulacijeRepromaterijalaZavisniTroskovi = new HashSet<KalkulacijeRepromaterijalaZavisniTroskovi>();
            KalkulacijeZavisniTroskovi = new HashSet<KalkulacijeZavisniTroskovi>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string NacinObracunaIznosa { get; set; }
        public string KontoObaveze { get; set; }
        public string Osnovica { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual AnalitickaKonta KontoObavezeNavigation { get; set; }
        public virtual ICollection<KalkulacijeRepromaterijalaZavisniTroskovi> KalkulacijeRepromaterijalaZavisniTroskovi { get; set; }
        public virtual ICollection<KalkulacijeZavisniTroskovi> KalkulacijeZavisniTroskovi { get; set; }
    }
}
