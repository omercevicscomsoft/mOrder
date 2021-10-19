using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PresjeciStanjaMp
    {
        public string SifraOrganizacioneJedinice { get; set; }
        public string SifraArtikla { get; set; }
        public int Id { get; set; }
        public decimal Kolicina { get; set; }
        public decimal MaloprodajnaCijena { get; set; }
        public DateTime DatumDokumenta { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal NabavnaCijena { get; set; }

        public virtual Artikli SifraArtiklaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOrganizacioneJediniceNavigation { get; set; }
    }
}
