using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class KamatniKalkulator
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public decimal IznosZaObracun { get; set; }
        public DateTime OdDatuma { get; set; }
        public DateTime DoDatuma { get; set; }
        public decimal GodisnjaStopa { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MetodaObracuna { get; set; }
    }
}
