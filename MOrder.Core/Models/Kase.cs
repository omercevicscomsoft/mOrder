using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Kase
    {
        public Kase()
        {
            DokumentiPrometaMp = new HashSet<DokumentiPrometaMp>();
        }

        public string Sifra { get; set; }
        public string Opis { get; set; }
        public int PocetniBrojRacuna { get; set; }
        public int ZadnjiBrojRacuna { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SifraOrganizacioneJedinice { get; set; }
        public string SifraSmjene { get; set; }

        public virtual OrganizacioneJedinice SifraOrganizacioneJediniceNavigation { get; set; }
        public virtual ICollection<DokumentiPrometaMp> DokumentiPrometaMp { get; set; }
    }
}
