using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class GrupaPripremljenihRacuna
    {
        public GrupaPripremljenihRacuna()
        {
            PripremljeniRacuni = new HashSet<PripremljeniRacuni>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string PeriodFakturisanja { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<PripremljeniRacuni> PripremljeniRacuni { get; set; }
    }
}
