using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class DokumentiPrometaMp
    {
        public DokumentiPrometaMp()
        {
            StavkePrometaMp = new HashSet<StavkePrometaMp>();
        }

        public string SifraOrganizacioneJedinice { get; set; }
        public string VrstaPrometa { get; set; }
        public string BrojDokumenta { get; set; }
        public DateTime DatumDokumenta { get; set; }
        public string OpisDokumenta { get; set; }
        public string SifraPoslovnogPartnera { get; set; }
        public string OrganizacionaJedinicaZaPrenos { get; set; }
        public string SifraPotrosaca { get; set; }
        public string UserNameProdavaca { get; set; }
        public string NacinPlacanja { get; set; }
        public string OznakaKase { get; set; }
        public string Smjena { get; set; }
        public string SifraOdjela { get; set; }
        public int? BrojFiskalnogRacuna { get; set; }
        public int? BrojReklamiranogFiskalnogRacuna { get; set; }
        public string SifraPovremenogKupca { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string BrojRadnogNaloga { get; set; }
        public string BrojRadnogNalogaProizvodnje { get; set; }

        public virtual RadniNalogMp BrojRadnogNalogaNavigation { get; set; }
        public virtual RadniNalogProizvodnje BrojRadnogNalogaProizvodnjeNavigation { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinicaZaPrenosNavigation { get; set; }
        public virtual Kase OznakaKaseNavigation { get; set; }
        public virtual Odjeli SifraOdjelaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOrganizacioneJediniceNavigation { get; set; }
        public virtual PoslovniPartneri SifraPoslovnogPartneraNavigation { get; set; }
        public virtual Potrosaci SifraPotrosacaNavigation { get; set; }
        public virtual PovremeniKupci SifraPovremenogKupcaNavigation { get; set; }
        public virtual Prodavaci UserNameProdavacaNavigation { get; set; }
        public virtual ICollection<StavkePrometaMp> StavkePrometaMp { get; set; }
    }
}
