using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Takse
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string SifraGrupeArtikala { get; set; }
        public string SifraArtikla { get; set; }
        public string KontoObaveze { get; set; }
        public string KontoUkalkulisaneTakse { get; set; }
        public string OpisKnjizenjaUgk { get; set; }
        public string SifraTeksta { get; set; }
        public decimal Kolicina { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string KontoRealiziraniPdvObveznicima { get; set; }
        public string KontoRealiziraniPdvNeobveznicima { get; set; }
        public bool KnjizitiUkalkulisanuTaksu { get; set; }
        public bool KnjizitiRealizacijuPdvTakse { get; set; }
        public bool? Aktivna { get; set; }

        public virtual AnalitickaKonta KontoObavezeNavigation { get; set; }
        public virtual AnalitickaKonta KontoRealiziraniPdvNeobveznicimaNavigation { get; set; }
        public virtual AnalitickaKonta KontoRealiziraniPdvObveznicimaNavigation { get; set; }
        public virtual AnalitickaKonta KontoUkalkulisaneTakseNavigation { get; set; }
        public virtual Artikli SifraArtiklaNavigation { get; set; }
        public virtual GrupeArtikala SifraGrupeArtikalaNavigation { get; set; }
        public virtual Tekstovi SifraTekstaNavigation { get; set; }
    }
}
