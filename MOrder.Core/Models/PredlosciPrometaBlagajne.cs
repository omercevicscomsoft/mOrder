using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PredlosciPrometaBlagajne
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public string SifraKonto { get; set; }
        public string VrstaDokumenta { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SifraPartnera { get; set; }
        public string CashFlowItemId { get; set; }

        public virtual CashFlowItems CashFlowItem { get; set; }
        public virtual AnalitickaKonta SifraKontoNavigation { get; set; }
        public virtual PoslovniPartneri SifraPartneraNavigation { get; set; }
    }
}
