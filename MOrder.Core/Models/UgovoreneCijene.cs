using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class UgovoreneCijene
    {
        public UgovoreneCijene()
        {
            StavkeUgovorenihCijena = new HashSet<StavkeUgovorenihCijena>();
        }

        public string Sifra { get; set; }
        public string Opis { get; set; }
        public DateTime VrijediOdDatuma { get; set; }
        public bool Aktivan { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string KupacId { get; set; }

        public virtual PoslovniPartneri Kupac { get; set; }
        public virtual ICollection<StavkeUgovorenihCijena> StavkeUgovorenihCijena { get; set; }
    }
}
