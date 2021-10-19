using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class GrupeArtikala
    {
        public GrupeArtikala()
        {
            Artikli = new HashSet<Artikli>();
            PodgrupeArtikala = new HashSet<PodgrupeArtikala>();
            Repromaterijal = new HashSet<Repromaterijal>();
            Takse = new HashSet<Takse>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string KontoPrihoda { get; set; }
        public byte[] Slika { get; set; }
        public string KontoPrihodaInostranoTrziste { get; set; }

        public virtual AnalitickaKonta KontoPrihodaInostranoTrzisteNavigation { get; set; }
        public virtual AnalitickaKonta KontoPrihodaNavigation { get; set; }
        public virtual ICollection<Artikli> Artikli { get; set; }
        public virtual ICollection<PodgrupeArtikala> PodgrupeArtikala { get; set; }
        public virtual ICollection<Repromaterijal> Repromaterijal { get; set; }
        public virtual ICollection<Takse> Takse { get; set; }
    }
}
