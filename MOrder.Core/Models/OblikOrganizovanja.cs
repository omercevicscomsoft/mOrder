using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class OblikOrganizovanja
    {
        public OblikOrganizovanja()
        {
            Firma = new HashSet<Firma>();
            PoslovniPartneri = new HashSet<PoslovniPartneri>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string SkraceniNaziv { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Firma> Firma { get; set; }
        public virtual ICollection<PoslovniPartneri> PoslovniPartneri { get; set; }
    }
}
