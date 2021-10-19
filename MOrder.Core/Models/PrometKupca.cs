using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class PrometKupca
    {
        public int Id { get; set; }
        public string BrojNaloga { get; set; }
        public string PartnerSifra { get; set; }
        public string DokumentSifra { get; set; }
        public int Veza { get; set; }
        public DateTime DatumDokumenta { get; set; }
        public DateTime DatumDpo { get; set; }
        public string KomercijalistaSifra { get; set; }
        public decimal Iznos { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string OpisKnjizenja { get; set; }
        public string ValutaSifra { get; set; }
        public decimal? IznosStraneValute { get; set; }
        public string OrganizacionaJedinicaSifra { get; set; }
        public bool SumnjivoIspornoPotrazivanje { get; set; }

        public virtual NaloziKupca BrojNalogaNavigation { get; set; }
        public virtual Dokumenti DokumentSifraNavigation { get; set; }
        public virtual Komercijalisti KomercijalistaSifraNavigation { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinicaSifraNavigation { get; set; }
        public virtual PoslovniPartneri PartnerSifraNavigation { get; set; }
        public virtual KursnaLista ValutaSifraNavigation { get; set; }
    }
}
