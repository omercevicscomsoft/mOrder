using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class GrupeUsluga
    {
        public GrupeUsluga()
        {
            StavkeKnjiznihObavijesti = new HashSet<StavkeKnjiznihObavijesti>();
            StavkeRacunaVp = new HashSet<StavkeRacunaVp>();
            Usluge = new HashSet<Usluge>();
        }

        public string Sifra { get; set; }
        public string Opis { get; set; }
        public string KontoPrihoda { get; set; }
        public bool Usluga { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string KontoPrihodaInostranoTrziste { get; set; }

        public virtual AnalitickaKonta KontoPrihodaInostranoTrzisteNavigation { get; set; }
        public virtual AnalitickaKonta KontoPrihodaNavigation { get; set; }
        public virtual ICollection<StavkeKnjiznihObavijesti> StavkeKnjiznihObavijesti { get; set; }
        public virtual ICollection<StavkeRacunaVp> StavkeRacunaVp { get; set; }
        public virtual ICollection<Usluge> Usluge { get; set; }
    }
}
