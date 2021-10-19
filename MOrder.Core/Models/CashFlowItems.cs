using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class CashFlowItems
    {
        public CashFlowItems()
        {
            PredlosciPrometaBlagajne = new HashSet<PredlosciPrometaBlagajne>();
            PrometGk = new HashSet<PrometGk>();
            PrometiBlagajne = new HashSet<PrometiBlagajne>();
        }

        public string Aop { get; set; }
        public string Opis { get; set; }
        public bool Priliv { get; set; }
        public decimal? IznosProslaGodina { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<PredlosciPrometaBlagajne> PredlosciPrometaBlagajne { get; set; }
        public virtual ICollection<PrometGk> PrometGk { get; set; }
        public virtual ICollection<PrometiBlagajne> PrometiBlagajne { get; set; }
    }
}
