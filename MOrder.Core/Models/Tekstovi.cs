using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Tekstovi
    {
        public Tekstovi()
        {
            KnjizneObavijesti = new HashSet<KnjizneObavijesti>();
            NarudzbeniceDobavljacu = new HashSet<NarudzbeniceDobavljacu>();
            PripremljeniRacuni = new HashSet<PripremljeniRacuni>();
            RacuniVp = new HashSet<RacuniVp>();
            Takse = new HashSet<Takse>();
        }

        public string Sifra { get; set; }
        public string Opis { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool DefaultText { get; set; }
        public bool IosKupca { get; set; }
        public bool IosDobavljaca { get; set; }

        public virtual ICollection<KnjizneObavijesti> KnjizneObavijesti { get; set; }
        public virtual ICollection<NarudzbeniceDobavljacu> NarudzbeniceDobavljacu { get; set; }
        public virtual ICollection<PripremljeniRacuni> PripremljeniRacuni { get; set; }
        public virtual ICollection<RacuniVp> RacuniVp { get; set; }
        public virtual ICollection<Takse> Takse { get; set; }
    }
}
