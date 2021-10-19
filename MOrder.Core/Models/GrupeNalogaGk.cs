using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class GrupeNalogaGk
    {
        public GrupeNalogaGk()
        {
            Blagajne = new HashSet<Blagajne>();
            OrganizacioneJediniceGrupaNalogaGotovinskeProdajeNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceGrupaNalogaKalkulacijaNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceGrupaNalogaKnjiznaObavijestDobavljaciNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceGrupaNalogaKnjiznaObavijestKupciNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceGrupaNalogaKompenzacijeNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceGrupaNalogaOtipsDoDozvoljenogIznosaNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceGrupaNalogaOtpisPrekoDozvoljenogIznosaNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceGrupaNalogaRacunNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceGrupaNalogaZapisnikaNavigation = new HashSet<OrganizacioneJedinice>();
            PridruzeneGrupeNaloga = new HashSet<PridruzeneGrupeNaloga>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int VrstaNaloga { get; set; }
        public string VezaSaKifKuf { get; set; }

        public virtual ICollection<Blagajne> Blagajne { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceGrupaNalogaGotovinskeProdajeNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceGrupaNalogaKalkulacijaNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceGrupaNalogaKnjiznaObavijestDobavljaciNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceGrupaNalogaKnjiznaObavijestKupciNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceGrupaNalogaKompenzacijeNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceGrupaNalogaOtipsDoDozvoljenogIznosaNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceGrupaNalogaOtpisPrekoDozvoljenogIznosaNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceGrupaNalogaRacunNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceGrupaNalogaZapisnikaNavigation { get; set; }
        public virtual ICollection<PridruzeneGrupeNaloga> PridruzeneGrupeNaloga { get; set; }
    }
}
