using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class NaloziKompenzacije
    {
        public NaloziKompenzacije()
        {
            StavkeNalogaKompenzacije = new HashSet<StavkeNalogaKompenzacije>();
        }

        public string Sifra { get; set; }
        public string SifraPp { get; set; }
        public DateTime Datum { get; set; }
        public DateTime UtvrdjenoNaDan { get; set; }
        public string OpisKompenzacije { get; set; }
        public string TekstZaglavlja { get; set; }
        public string TekstPodnozja { get; set; }
        public bool KompenzacijaRealizirana { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SifraOj { get; set; }

        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual PoslovniPartneri SifraPpNavigation { get; set; }
        public virtual ICollection<StavkeNalogaKompenzacije> StavkeNalogaKompenzacije { get; set; }
    }
}
