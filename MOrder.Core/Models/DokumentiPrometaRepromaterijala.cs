using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class DokumentiPrometaRepromaterijala
    {
        public DokumentiPrometaRepromaterijala()
        {
            StavkePrometaRepromaterijala = new HashSet<StavkePrometaRepromaterijala>();
        }

        public string SkladisteId { get; set; }
        public string VrstaPrometaId { get; set; }
        public string BrojDokumenta { get; set; }
        public DateTime DatumDokumenta { get; set; }
        public string OpisDokumenta { get; set; }
        public string PoslovniPartnerId { get; set; }
        public string OrganizacionaJedinicaId { get; set; }
        public Guid Guid { get; set; }
        public string BrojRadnogNaloga { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RadniNalogProizvodnje BrojRadnogNalogaNavigation { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinica { get; set; }
        public virtual PoslovniPartneri PoslovniPartner { get; set; }
        public virtual OrganizacioneJedinice Skladiste { get; set; }
        public virtual ICollection<StavkePrometaRepromaterijala> StavkePrometaRepromaterijala { get; set; }
    }
}
