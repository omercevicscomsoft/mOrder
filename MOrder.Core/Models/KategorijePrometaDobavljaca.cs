using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class KategorijePrometaDobavljaca
    {
        public KategorijePrometaDobavljaca()
        {
            PrometDobavljaca = new HashSet<PrometDobavljaca>();
        }

        public string Sifra { get; set; }
        public string Opis { get; set; }
        public string Konto { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual AnalitickaKonta KontoNavigation { get; set; }
        public virtual ICollection<PrometDobavljaca> PrometDobavljaca { get; set; }
    }
}
