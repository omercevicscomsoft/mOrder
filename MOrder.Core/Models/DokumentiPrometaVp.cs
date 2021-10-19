using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class DokumentiPrometaVp
    {
        public DokumentiPrometaVp()
        {
            StavkePrometaVp = new HashSet<StavkePrometaVp>();
        }

        public string SkladisteId { get; set; }
        public string VrstaPrometaId { get; set; }
        public string BrojDokumenta { get; set; }
        public DateTime DatumDokumenta { get; set; }
        public string OpisDokumenta { get; set; }
        public string PoslovniPartnerId { get; set; }
        public string OrganizacionaJedinicaId { get; set; }
        public Guid Guid { get; set; }
        public string SifraPoslovneJedinice { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string BrojRadnogNalogaProizvodnje { get; set; }
        public string BrojOtpremniceVeleprodajeUtoku { get; set; }

        public virtual OtpremniceVeleprodajeUtoku BrojOtpremniceVeleprodajeUtokuNavigation { get; set; }
        public virtual RadniNalogProizvodnje BrojRadnogNalogaProizvodnjeNavigation { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinica { get; set; }
        public virtual PoslovneJedinice PoslovneJedinice { get; set; }
        public virtual PoslovniPartneri PoslovniPartner { get; set; }
        public virtual OrganizacioneJedinice Skladiste { get; set; }
        public virtual ICollection<StavkePrometaVp> StavkePrometaVp { get; set; }
    }
}
