using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class StavkeBilansaUspjeha
    {
        public string Aop { get; set; }
        public string Opis { get; set; }
        public decimal? IznosProslaGodina { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal FiksniIznos { get; set; }
        public string Formula { get; set; }
        public string NacinObracuna { get; set; }
    }
}
