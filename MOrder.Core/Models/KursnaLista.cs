using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class KursnaLista
    {
        public KursnaLista()
        {
            Blagajne = new HashSet<Blagajne>();
            PrometDobavljaca = new HashSet<PrometDobavljaca>();
            PrometKupca = new HashSet<PrometKupca>();
        }

        public string SifraValute { get; set; }
        public string Zemlja { get; set; }
        public string OznakaValute { get; set; }
        public int Jedinica { get; set; }
        public decimal KupovniKurs { get; set; }
        public decimal SrednjiKurs { get; set; }
        public decimal ProdajniKurs { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Blagajne> Blagajne { get; set; }
        public virtual ICollection<PrometDobavljaca> PrometDobavljaca { get; set; }
        public virtual ICollection<PrometKupca> PrometKupca { get; set; }
    }
}
