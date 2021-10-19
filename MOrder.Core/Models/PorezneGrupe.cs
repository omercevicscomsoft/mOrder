using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class PorezneGrupe
    {
        public PorezneGrupe()
        {
            Artikli = new HashSet<Artikli>();
            PripremljeniRacuni = new HashSet<PripremljeniRacuni>();
            Repromaterijal = new HashSet<Repromaterijal>();
            StavkeKnjiznihObavijesti = new HashSet<StavkeKnjiznihObavijesti>();
            StavkeNarudzbeniceDobavljacu = new HashSet<StavkeNarudzbeniceDobavljacu>();
            StavkeRacunaVp = new HashSet<StavkeRacunaVp>();
            Usluge = new HashSet<Usluge>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public decimal Stopa { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string FiskalnaOznaka { get; set; }
        public string KontoUlazniPdvdomaci { get; set; }
        public string KontoUlazniPdvuvoz { get; set; }

        public virtual AnalitickaKonta KontoUlazniPdvdomaciNavigation { get; set; }
        public virtual AnalitickaKonta KontoUlazniPdvuvozNavigation { get; set; }
        public virtual ICollection<Artikli> Artikli { get; set; }
        public virtual ICollection<PripremljeniRacuni> PripremljeniRacuni { get; set; }
        public virtual ICollection<Repromaterijal> Repromaterijal { get; set; }
        public virtual ICollection<StavkeKnjiznihObavijesti> StavkeKnjiznihObavijesti { get; set; }
        public virtual ICollection<StavkeNarudzbeniceDobavljacu> StavkeNarudzbeniceDobavljacu { get; set; }
        public virtual ICollection<StavkeRacunaVp> StavkeRacunaVp { get; set; }
        public virtual ICollection<Usluge> Usluge { get; set; }
    }
}
