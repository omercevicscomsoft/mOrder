using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class KalkulacijeRepromaterijala
    {
        public KalkulacijeRepromaterijala()
        {
            StavkeKalkulacijeRepromaterijala = new HashSet<StavkeKalkulacijeRepromaterijala>();
        }

        public string SkladisteId { get; set; }
        public string BrojKalkulacije { get; set; }
        public DateTime DatumKalkulacije { get; set; }
        public string DobavljacId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime DatumRacuna { get; set; }
        public decimal UlazniPdv { get; set; }
        public string OpisKalkulacije { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid Guid { get; set; }

        public virtual PoslovniPartneri Dobavljac { get; set; }
        public virtual OrganizacioneJedinice Skladiste { get; set; }
        public virtual ICollection<StavkeKalkulacijeRepromaterijala> StavkeKalkulacijeRepromaterijala { get; set; }
    }
}
