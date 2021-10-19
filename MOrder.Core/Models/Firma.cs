using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class Firma
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string NazivExt { get; set; }
        public string Ulica { get; set; }
        public string BrojUlice { get; set; }
        public string PttBroj { get; set; }
        public string SifraOpcine { get; set; }
        public string PorezniBroj { get; set; }
        public bool PdvObveznik { get; set; }
        public string PdvBroj { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Mobitel { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string OdgovornoLice { get; set; }
        public string Napomena { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string OblikOrganizacije { get; set; }
        public string DjelatnostId { get; set; }
        public string Jmbgol { get; set; }
        public string ImeIprezimeRac { get; set; }
        public string BrojDozvoleRac { get; set; }
        public string IdbrojRac { get; set; }
        public string TelefonRac { get; set; }
        public string RegBrojUpisa { get; set; }
        public string Sud { get; set; }
        public string ImeIprezimeZastupnika { get; set; }
        public string AdresaZastupnika { get; set; }
        public DateTime? DatumUpisa { get; set; }
        public string ZaglavljePortretPrva { get; set; }
        public string ZaglavljePortretOstalo { get; set; }
        public string ZaglavljeLandscapePrva { get; set; }
        public string ZaglavljeLandscapeOstalo { get; set; }
        public string RacunZaglavlje { get; set; }
        public bool PrikazKupcaLijevo { get; set; }
        public string RacunPodnozje { get; set; }
        public bool FooterFirmaProizvodjac { get; set; }
        public bool FooterDatum { get; set; }
        public bool FooterOperater { get; set; }
        public string OznakaValute { get; set; }
        public string SifraUposlovnimPartnerima { get; set; }
        public string SifraZaVanposlovneSvrhe { get; set; }
        public string SifraZaGotovinskuProdaju { get; set; }
        public string RacunPotpisnici { get; set; }

        public virtual Djelatnosti Djelatnost { get; set; }
        public virtual OblikOrganizovanja OblikOrganizacijeNavigation { get; set; }
        public virtual Mjesta PttBrojNavigation { get; set; }
        public virtual Opcine SifraOpcineNavigation { get; set; }
    }
}
