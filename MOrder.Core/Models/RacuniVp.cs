using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class RacuniVp
    {
        public RacuniVp()
        {
            StavkeRacunaVp = new HashSet<StavkeRacunaVp>();
        }

        public string SifraOj { get; set; }
        public string VrstaRacuna { get; set; }
        public string BrojRacuna { get; set; }
        public string KupacId { get; set; }
        public DateTime DatumRacuna { get; set; }
        public DateTime DatumDpo { get; set; }
        public string SifraTeksta { get; set; }
        public string BrojOtpremnice { get; set; }
        public DateTime? DatumOtpremnice { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime? DatumNarudzbe { get; set; }
        public string OpisRacuna { get; set; }
        public string Napomena { get; set; }
        public string SifraKomercijaliste { get; set; }
        public int? BrojFiskalnogRacuna { get; set; }
        public int? BrojReklamiranogFiskalnogRacuna { get; set; }
        public string NacinPlacanja { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string PripremljeniRacunId { get; set; }
        public string BrojRadnogNalogaMp { get; set; }
        public string VezniDokument { get; set; }
        public string BrojRadnogNalogaProizvodnje { get; set; }
        public string BrojOtpremniceVeleprodajeUtoku { get; set; }

        public virtual OtpremniceVeleprodajeUtoku BrojOtpremniceVeleprodajeUtokuNavigation { get; set; }
        public virtual RadniNalogMp BrojRadnogNalogaMpNavigation { get; set; }
        public virtual RadniNalogProizvodnje BrojRadnogNalogaProizvodnjeNavigation { get; set; }
        public virtual PoslovniPartneri Kupac { get; set; }
        public virtual Komercijalisti SifraKomercijalisteNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual Tekstovi SifraTekstaNavigation { get; set; }
        public virtual ICollection<StavkeRacunaVp> StavkeRacunaVp { get; set; }
    }
}
