using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class RadniNalogProizvodnje
    {
        public RadniNalogProizvodnje()
        {
            DokumentiPrometaMp = new HashSet<DokumentiPrometaMp>();
            DokumentiPrometaRepromaterijala = new HashSet<DokumentiPrometaRepromaterijala>();
            DokumentiPrometaVp = new HashSet<DokumentiPrometaVp>();
            GotoviProizvodiRadnogNalogaProizvodnje = new HashSet<GotoviProizvodiRadnogNalogaProizvodnje>();
            RacuniVp = new HashSet<RacuniVp>();
        }

        public string Broj { get; set; }
        public string SkladisteId { get; set; }
        public DateTime Datum { get; set; }
        public string OpisPotrebnihRadova { get; set; }
        public string SifraKupca { get; set; }
        public DateTime? DatumZavrsetkaRadova { get; set; }
        public string SifraUsluge { get; set; }
        public decimal? CijenaUsluge { get; set; }
        public string OpisUsluge { get; set; }
        public bool ProizvodnjaPrekoNormativa { get; set; }
        public bool ZatvorenRadniNalog { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string TrgovackoSkladiste { get; set; }
        public decimal ProcenatOpcihTroskovaProizvodnje { get; set; }
        public Guid? Guid { get; set; }

        public virtual PoslovniPartneri SifraKupcaNavigation { get; set; }
        public virtual OrganizacioneJedinice Skladiste { get; set; }
        public virtual OrganizacioneJedinice TrgovackoSkladisteNavigation { get; set; }
        public virtual ICollection<DokumentiPrometaMp> DokumentiPrometaMp { get; set; }
        public virtual ICollection<DokumentiPrometaRepromaterijala> DokumentiPrometaRepromaterijala { get; set; }
        public virtual ICollection<DokumentiPrometaVp> DokumentiPrometaVp { get; set; }
        public virtual ICollection<GotoviProizvodiRadnogNalogaProizvodnje> GotoviProizvodiRadnogNalogaProizvodnje { get; set; }
        public virtual ICollection<RacuniVp> RacuniVp { get; set; }
    }
}
