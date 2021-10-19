using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class NaloziZaPlacanjePrintOptionsDetail
    {
        public string NalogZaPlacanjePrintOptionsId { get; set; }
        public string VrstaPodatkaId { get; set; }
        public int RedIspisa { get; set; }
        public int KolonaIspisa { get; set; }
        public bool Ispis { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual NaloziZaPlacanjePrintOptionsMaster NalogZaPlacanjePrintOptions { get; set; }
    }
}
