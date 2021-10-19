using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class KnjizneObavijesti
    {
        public KnjizneObavijesti()
        {
            StavkeKnjiznihObavijesti = new HashSet<StavkeKnjiznihObavijesti>();
        }

        public string SifraOj { get; set; }
        public string VrstaKnjizneObavijesti { get; set; }
        public string BrojKnjizneObavijesti { get; set; }
        public string PoslovniPartnerId { get; set; }
        public DateTime DatumRacuna { get; set; }
        public DateTime DatumDpo { get; set; }
        public string SifraTeksta { get; set; }
        public string BrojOtpremnice { get; set; }
        public DateTime? DatumOtpremnice { get; set; }
        public string OriginalniDokument { get; set; }
        public DateTime? DatumDokumenta { get; set; }
        public string OpisRacuna { get; set; }
        public string Napomena { get; set; }
        public string SifraKomercijaliste { get; set; }
        public int? BrojFiskalnogRacuna { get; set; }
        public int? BrojReklamiranogFiskalnogRacuna { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual PoslovniPartneri PoslovniPartner { get; set; }
        public virtual Komercijalisti SifraKomercijalisteNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual Tekstovi SifraTekstaNavigation { get; set; }
        public virtual ICollection<StavkeKnjiznihObavijesti> StavkeKnjiznihObavijesti { get; set; }
    }
}
