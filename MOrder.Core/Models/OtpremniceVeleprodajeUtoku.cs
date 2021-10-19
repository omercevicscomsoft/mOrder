using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class OtpremniceVeleprodajeUtoku
    {
        public OtpremniceVeleprodajeUtoku()
        {
            DokumentiPrometaVp = new HashSet<DokumentiPrometaVp>();
            RacuniVp = new HashSet<RacuniVp>();
        }

        public string Broj { get; set; }
        public string OrganizacionaJedinicaId { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
        public string KupacId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid Guid { get; set; }
        public bool Zavrsena { get; set; }

        public virtual PoslovniPartneri Kupac { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinica { get; set; }
        public virtual ICollection<DokumentiPrometaVp> DokumentiPrometaVp { get; set; }
        public virtual ICollection<RacuniVp> RacuniVp { get; set; }
    }
}
