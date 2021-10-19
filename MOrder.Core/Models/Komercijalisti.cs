using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Komercijalisti
    {
        public Komercijalisti()
        {
            KnjizneObavijesti = new HashSet<KnjizneObavijesti>();
            NarudzbeniceKupca = new HashSet<NarudzbeniceKupca>();
            PripremljeniRacuni = new HashSet<PripremljeniRacuni>();
            PrometKupca = new HashSet<PrometKupca>();
            RacuniVp = new HashSet<RacuniVp>();
            StavkeNarudzbeniceKupca = new HashSet<StavkeNarudzbeniceKupca>();
        }

        public string Sifra { get; set; }
        public string ImePrezime { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Vrsta { get; set; }
        public decimal PostotakKorekcije { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Aktivan { get; set; }
        public string Napomena { get; set; }

        public virtual ICollection<KnjizneObavijesti> KnjizneObavijesti { get; set; }
        public virtual ICollection<NarudzbeniceKupca> NarudzbeniceKupca { get; set; }
        public virtual ICollection<PripremljeniRacuni> PripremljeniRacuni { get; set; }
        public virtual ICollection<PrometKupca> PrometKupca { get; set; }
        public virtual ICollection<RacuniVp> RacuniVp { get; set; }
        public virtual ICollection<StavkeNarudzbeniceKupca> StavkeNarudzbeniceKupca { get; set; }
    }
}
