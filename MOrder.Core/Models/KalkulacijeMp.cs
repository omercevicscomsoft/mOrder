using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class KalkulacijeMp
    {
        public KalkulacijeMp()
        {
            ArtikliKalkulacijeMp = new HashSet<ArtikliKalkulacijeMp>();
        }

        public string SifraOj { get; set; }
        public string BrojKalkulacije { get; set; }
        public DateTime DatumKalkulacije { get; set; }
        public string SifraDobavljaca { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime DatumRacuna { get; set; }
        public decimal UlazniPdv { get; set; }
        public string OpisKalkulacije { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid Guid { get; set; }
        public int VrstaUlaza { get; set; }
        public string SifraOjdonosa { get; set; }

        public virtual PoslovniPartneri SifraDobavljacaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjdonosaNavigation { get; set; }
        public virtual ICollection<ArtikliKalkulacijeMp> ArtikliKalkulacijeMp { get; set; }
    }
}
