using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class ObrazacSl2
    {
        public ObrazacSl2()
        {
            StavkaObrascaSl2 = new HashSet<StavkaObrascaSl2>();
        }

        public string SifraOj { get; set; }
        public string RedniBroj { get; set; }
        public DateTime Datum { get; set; }
        public int Stranac { get; set; }
        public DateTime DatumnPrijema { get; set; }
        public DateTime DatumPovrata { get; set; }
        public decimal IznosPovrata { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid Guid { get; set; }

        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual StraniDrzavljani StranacNavigation { get; set; }
        public virtual ICollection<StavkaObrascaSl2> StavkaObrascaSl2 { get; set; }
    }
}
