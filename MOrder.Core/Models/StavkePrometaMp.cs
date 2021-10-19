using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkePrometaMp
    {
        public int Id { get; set; }
        public string SifraOrganizacioneJedinice { get; set; }
        public string VrstaPrometa { get; set; }
        public string BrojDokumenta { get; set; }
        public string SifraArtikla { get; set; }
        public decimal Kolicina { get; set; }
        public decimal MaloprodajnaCijena { get; set; }
        public decimal NabavnaCijena { get; set; }
        public decimal PrethodnaMaloprodajnaCijena { get; set; }
        public decimal PostotakPopusta { get; set; }
        public string OpisPrometa { get; set; }
        public int RedniBroj { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual DokumentiPrometaMp DokumentiPrometaMp { get; set; }
        public virtual Artikli SifraArtiklaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOrganizacioneJediniceNavigation { get; set; }
    }
}
