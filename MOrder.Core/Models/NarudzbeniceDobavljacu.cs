using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class NarudzbeniceDobavljacu
    {
        public NarudzbeniceDobavljacu()
        {
            StavkeNarudzbeniceDobavljacu = new HashSet<StavkeNarudzbeniceDobavljacu>();
        }

        public string OrganizacionaJedinicaId { get; set; }
        public string Broj { get; set; }
        public string DobavljacId { get; set; }
        public DateTime Datum { get; set; }
        public string TekstId { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
        public string MjestoIsporuke { get; set; }
        public string OsobaZaKontakt { get; set; }
        public string Telefon { get; set; }
        public bool Realizirana { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual PoslovniPartneri Dobavljac { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinica { get; set; }
        public virtual Tekstovi Tekst { get; set; }
        public virtual ICollection<StavkeNarudzbeniceDobavljacu> StavkeNarudzbeniceDobavljacu { get; set; }
    }
}
