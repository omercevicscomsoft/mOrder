using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PomocnePopisneListeRepromaterijala
    {
        public string OrganizacionaJedinicaId { get; set; }
        public string RepromaterijalId { get; set; }
        public int Id { get; set; }
        public decimal Kolicina { get; set; }
        public decimal PopisnaKolicina { get; set; }
        public DateTime DatumDokumenta { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal NabavnaCijena { get; set; }
        public string OpisPrometa { get; set; }
        public DateTime? DatumPrvogUlaza { get; set; }
        public DateTime? DatumZadnjegUlaza { get; set; }

        public virtual OrganizacioneJedinice OrganizacionaJedinica { get; set; }
        public virtual Repromaterijal Repromaterijal { get; set; }
    }
}
