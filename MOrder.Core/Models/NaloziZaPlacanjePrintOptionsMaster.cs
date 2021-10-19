using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class NaloziZaPlacanjePrintOptionsMaster
    {
        public NaloziZaPlacanjePrintOptionsMaster()
        {
            NaloziZaPlacanjePrintOptionsDetail = new HashSet<NaloziZaPlacanjePrintOptionsDetail>();
        }

        public string NalogZaPlacanjePrintOptionsId { get; set; }
        public string Naziv { get; set; }
        public bool Aktivan { get; set; }
        public bool Default { get; set; }
        public bool Bold { get; set; }
        public string PrinterName { get; set; }
        public string OznakaIspredIznosa { get; set; }
        public string OznakaIzaIznosa { get; set; }
        public int BrojRedovaPomakaTop { get; set; }
        public int BrojMalihPomakaTop { get; set; }
        public int BrojRedovaPomakaBottom { get; set; }
        public int BrojMalihPomakaBottom { get; set; }
        public bool IspisDijelovaDatumaOdvojeno { get; set; }
        public bool IspisZnakovaBudzetskeOrganizacijeOdvojeno { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<NaloziZaPlacanjePrintOptionsDetail> NaloziZaPlacanjePrintOptionsDetail { get; set; }
    }
}
