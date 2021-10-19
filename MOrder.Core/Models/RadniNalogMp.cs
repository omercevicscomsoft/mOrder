using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class RadniNalogMp
    {
        public RadniNalogMp()
        {
            DokumentiPrometaMp = new HashSet<DokumentiPrometaMp>();
            RacuniVp = new HashSet<RacuniVp>();
        }

        public string Broj { get; set; }
        public string SifraOj { get; set; }
        public string OpisPotrebnihRadova { get; set; }
        public string OpisIzvrsenihRadova { get; set; }
        public DateTime Datum { get; set; }
        public string ZaduzenoLice { get; set; }
        public string NalogJeOtvorio { get; set; }
        public string NalogJeZatvorio { get; set; }
        public string TipUredaja { get; set; }
        public string OznakaUredaja { get; set; }
        public DateTime? DatumZavrsetkaRadova { get; set; }
        public string SifraUsluge { get; set; }
        public decimal? CijenaUsluge { get; set; }
        public string OpisUsluge { get; set; }
        public bool ZatvorenRadniNalog { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SifraPp { get; set; }
        public string SifraVeleprodajneOj { get; set; }
        public Guid? Guid { get; set; }

        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual PoslovniPartneri SifraPpNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraVeleprodajneOjNavigation { get; set; }
        public virtual ICollection<DokumentiPrometaMp> DokumentiPrometaMp { get; set; }
        public virtual ICollection<RacuniVp> RacuniVp { get; set; }
    }
}
