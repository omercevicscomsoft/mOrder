using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PosPostavke
    {
        public string OrganizacionaJedinicaId { get; set; }
        public bool KolicinaSeObracunava { get; set; }
        public int DuzinaNajkracegBarKoda { get; set; }
        public string NacinPracenjaZalihe { get; set; }
        public string NacinIzboraArtikla { get; set; }
        public int UkupnaDuzinaBarKodaSaVage { get; set; }
        public int BrojZnakovaKojiOdredujuArtikl { get; set; }
        public int BrojZnakovaKojiOdredujuTezinu { get; set; }
        public int BrojDecimala { get; set; }
        public string PrefiksZaKolicinskiBarKod { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ZamjenskiArtiklZaFakturisanje1 { get; set; }
        public string ZamjenskiArtiklZaFakturisanje2 { get; set; }
        public string ZamjenskiArtiklZaFakturisanje3 { get; set; }
        public bool PopustNaNabavnuCijenuInterneSvrhe { get; set; }
        public bool ZamjenskiArtikliSeKoriste { get; set; }
        public bool KontrolisatiMinimalnuZalihuPriProdaji { get; set; }
        public bool IspisDuplikataGotovina { get; set; }
        public bool IspisDuplikataCek { get; set; }
        public bool IspisDuplikataKreditnaKartica { get; set; }
        public bool IspisDuplikataZiralnoPlacanje { get; set; }
        public bool? UkljucenaZvucnaSignalizacija { get; set; }
    }
}
