using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PomocnePopisneListeVp
    {
        public int Id { get; set; }
        public string SifraArtikla { get; set; }
        public decimal Kolicina { get; set; }
        public decimal PopisnaKolicina { get; set; }
        public decimal VeleprodajnaCijena { get; set; }
        public DateTime DatumDokumenta { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SifraOrganizacioneJedinice { get; set; }
        public decimal NabavnaCijena { get; set; }
        public DateTime? RokTrajanja { get; set; }
        public string BrojSerije { get; set; }
        public string BrojKontrolePrveSerije { get; set; }
        public string BrojKontroleSvakeSerije { get; set; }
        public string OpisPrometa { get; set; }
        public DateTime? DatumPrvogUlaza { get; set; }
        public DateTime? DatumZadnjegUlaza { get; set; }

        public virtual Artikli SifraArtiklaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOrganizacioneJediniceNavigation { get; set; }
    }
}
