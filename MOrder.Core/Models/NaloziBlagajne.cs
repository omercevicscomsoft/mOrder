using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class NaloziBlagajne
    {
        public NaloziBlagajne()
        {
            PrometiBlagajne = new HashSet<PrometiBlagajne>();
        }

        public string BlagajnaId { get; set; }
        public string Broj { get; set; }
        public DateTime DatumDokumenta { get; set; }
        public string OpisDokumenta { get; set; }
        public decimal Kurs { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Blagajne Blagajna { get; set; }
        public virtual ICollection<PrometiBlagajne> PrometiBlagajne { get; set; }
    }
}
