using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class PridruzeneGrupeNaloga
    {
        public string OrganizacionaJedinicaId { get; set; }
        public string VrstaDokumentaId { get; set; }
        public string GrupaNalogaId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual GrupeNalogaGk GrupaNaloga { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinica { get; set; }
    }
}
