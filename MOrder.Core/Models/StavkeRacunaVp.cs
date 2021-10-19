using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class StavkeRacunaVp
    {
        public int Id { get; set; }
        public string SifraOj { get; set; }
        public string VrstaRacuna { get; set; }
        public string BrojRacuna { get; set; }
        public string SifraGrupeUsluga { get; set; }
        public string SifraArtikla { get; set; }
        public string NazivArtikla { get; set; }
        public string JedinicaMjere { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal NabavnaCijena { get; set; }
        public string SifraPorezneGrupe { get; set; }
        public decimal Rabat1 { get; set; }
        public decimal Rabat2 { get; set; }
        public string NacinObracunaPdva { get; set; }
        public string Opis { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? RokTrajanja { get; set; }
        public string BrojSerije { get; set; }
        public string BrojKontrolePrveSerije { get; set; }
        public string BrojKontroleSvakeSerije { get; set; }
        public string SifraOjstavkeOtpremnice { get; set; }
        public string BarCodeArtikla { get; set; }
        public string KataloskiBrojArtikla { get; set; }
        public string ProizvodjacNaziv { get; set; }
        public string KlasifikacijaNaziv { get; set; }

        public virtual RacuniVp RacuniVp { get; set; }
        public virtual GrupeUsluga SifraGrupeUslugaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjstavkeOtpremniceNavigation { get; set; }
        public virtual PorezneGrupe SifraPorezneGrupeNavigation { get; set; }
    }
}
