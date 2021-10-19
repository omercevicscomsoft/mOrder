using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Dokumenti
    {
        public Dokumenti()
        {
            PrometDobavljaca = new HashSet<PrometDobavljaca>();
            PrometKupca = new HashSet<PrometKupca>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Strana { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool ObracunKamata { get; set; }
        public bool ZaGlavnuKnjigu { get; set; }
        public bool ZaBlagajnu { get; set; }
        public bool ZaIzlazneFakture { get; set; }
        public bool ZaKalkulacije { get; set; }
        public bool ZaKompenzacije { get; set; }
        public bool ZaKnjizneObavijesti { get; set; }

        public virtual ICollection<PrometDobavljaca> PrometDobavljaca { get; set; }
        public virtual ICollection<PrometKupca> PrometKupca { get; set; }
    }
}
