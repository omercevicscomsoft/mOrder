using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PripremljeniRacuni
    {
        public string SifraOj { get; set; }
        public string VrstaRacuna { get; set; }
        public string KupacId { get; set; }
        public string SifraTeksta { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime? DatumNarudzbe { get; set; }
        public string Napomena { get; set; }
        public string SifraKomercijaliste { get; set; }
        public string NacinPlacanja { get; set; }
        public string SifraGrupeUsluga { get; set; }
        public string SifraArtiklaUsluge { get; set; }
        public string NazivArtiklaUsluge { get; set; }
        public string JedinicaMjere { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal NabavnaCijena { get; set; }
        public string SifraPorezneGrupe { get; set; }
        public decimal Rabat1 { get; set; }
        public decimal Rabat2 { get; set; }
        public string NacinObracunaPdva { get; set; }
        public string NapomenaPripreme { get; set; }
        public bool Aktivan { get; set; }
        public string SifraGrupePripremljenihRacuna { get; set; }
        public string MjesecFakturisanja { get; set; }
        public DateTime OcekivaniDatumFakturisanja { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string PripremljeniRacunId { get; set; }
        public string Naziv { get; set; }
        public string OpisRacuna { get; set; }

        public virtual PoslovniPartneri Kupac { get; set; }
        public virtual GrupaPripremljenihRacuna SifraGrupePripremljenihRacunaNavigation { get; set; }
        public virtual Komercijalisti SifraKomercijalisteNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual PorezneGrupe SifraPorezneGrupeNavigation { get; set; }
        public virtual Tekstovi SifraTekstaNavigation { get; set; }
    }
}
