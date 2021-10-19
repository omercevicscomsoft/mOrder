using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class PrintedReports
    {
        public string Sifra { get; set; }
        public string Opis { get; set; }
        public string Naslov { get; set; }
        public string Iso { get; set; }
        public string ZaglavljeZaPrvu { get; set; }
        public string ZaglavljeZaOstale { get; set; }
        public bool FooterFirmaProizvodjac { get; set; }
        public bool FooterDatum { get; set; }
        public bool FooterOperater { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool Aktivan { get; set; }
        public int Modul { get; set; }
        public bool PrintThisNaslov { get; set; }
        public bool PrintThisIso { get; set; }
        public bool PrintThisZaglavljeZaPrvu { get; set; }
        public bool PrintThisZaglavljeZaOstale { get; set; }
        public bool ApplyThisFooterSettings { get; set; }
    }
}
