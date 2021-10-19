using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PrometiBlagajne
    {
        public int Id { get; set; }
        public string BlagajnaId { get; set; }
        public string Broj { get; set; }
        public string OpisKnjizenja { get; set; }
        public string SifraKonta { get; set; }
        public decimal IznosKnjizenja { get; set; }
        public string SifraPoslovnogPartnera { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string CashFlowItemId { get; set; }

        public virtual NaloziBlagajne B { get; set; }
        public virtual CashFlowItems CashFlowItem { get; set; }
        public virtual AnalitickaKonta SifraKontaNavigation { get; set; }
        public virtual PoslovniPartneri SifraPoslovnogPartneraNavigation { get; set; }
    }
}
