using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class StavkeKnjiznihObavijesti
    {
        public int Id { get; set; }
        public string SifraOj { get; set; }
        public string VrstaKnjizneObavijesti { get; set; }
        public string BrojKnjizneObavijesti { get; set; }
        public string SifraGrupeUsluga { get; set; }
        public string SifraArtikla { get; set; }
        public string NazivArtikla { get; set; }
        public string JedinicaMjere { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal NabavnaCijena { get; set; }
        public string SifraPorezneGrupe { get; set; }
        public decimal Rabat1 { get; set; }
        public string NacinObracunaPdva { get; set; }
        public string Opis { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual KnjizneObavijesti KnjizneObavijesti { get; set; }
        public virtual GrupeUsluga SifraGrupeUslugaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual PorezneGrupe SifraPorezneGrupeNavigation { get; set; }
    }
}
