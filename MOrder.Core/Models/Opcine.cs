using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Opcine
    {
        public Opcine()
        {
            Firma = new HashSet<Firma>();
            OrganizacioneJedinice = new HashSet<OrganizacioneJedinice>();
            PoslovniPartneri = new HashSet<PoslovniPartneri>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string IdRegija { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string IdKanton { get; set; }

        public virtual Kantoni IdKantonNavigation { get; set; }
        public virtual Regije IdRegijaNavigation { get; set; }
        public virtual ICollection<Firma> Firma { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJedinice { get; set; }
        public virtual ICollection<PoslovniPartneri> PoslovniPartneri { get; set; }
    }
}
