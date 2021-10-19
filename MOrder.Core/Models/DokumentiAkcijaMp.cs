using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class DokumentiAkcijaMp
    {
        public DokumentiAkcijaMp()
        {
            StavkeNaAkcijiMp = new HashSet<StavkeNaAkcijiMp>();
        }

        public string RedniBrojAkcije { get; set; }
        public string Opis { get; set; }
        public DateTime DatumVrijemePocetkaAkcije { get; set; }
        public DateTime DatumVrijemeZavrsetkaAkcije { get; set; }
        public decimal PopustZaSveArtikle { get; set; }
        public bool Aktivno { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool DozvoljeniOstaliPopusti { get; set; }
        public string SifraOrganizacioneJedinice { get; set; }

        public virtual OrganizacioneJedinice SifraOrganizacioneJediniceNavigation { get; set; }
        public virtual ICollection<StavkeNaAkcijiMp> StavkeNaAkcijiMp { get; set; }
    }
}
