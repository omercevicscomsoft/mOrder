using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkePrometaRepromaterijala
    {
        public int Id { get; set; }
        public string SkladisteId { get; set; }
        public string VrstaPrometaId { get; set; }
        public string BrojDokumenta { get; set; }
        public string RepromaterijalId { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual DokumentiPrometaRepromaterijala DokumentiPrometaRepromaterijala { get; set; }
        public virtual Repromaterijal Repromaterijal { get; set; }
    }
}
