using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class PrometDobavljaca
    {
        public int Id { get; set; }
        public string BrojNaloga { get; set; }
        public string PartnerSifra { get; set; }
        public string DokumentSifra { get; set; }
        public DateTime DatumDpo { get; set; }
        public decimal Iznos { get; set; }
        public string OpisKnjizenja { get; set; }
        public string ValutaSifra { get; set; }
        public decimal? IznosStraneValute { get; set; }
        public string SifraOj { get; set; }
        public string SifraKategorije { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int Veza { get; set; }
        public DateTime DatumDokumenta { get; set; }

        public virtual NaloziDobavljaca BrojNalogaNavigation { get; set; }
        public virtual Dokumenti DokumentSifraNavigation { get; set; }
        public virtual PoslovniPartneri PartnerSifraNavigation { get; set; }
        public virtual KategorijePrometaDobavljaca SifraKategorijeNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual KursnaLista ValutaSifraNavigation { get; set; }
    }
}
