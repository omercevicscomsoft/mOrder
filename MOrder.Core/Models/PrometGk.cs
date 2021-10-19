using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PrometGk
    {
        public int Id { get; set; }
        public string Broj { get; set; }
        public DateTime DatumDokumenta { get; set; }
        public string Opis { get; set; }
        public string OrganizacionaJedinicaId { get; set; }
        public string Konto { get; set; }
        public decimal Iznos { get; set; }
        public string Strana { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid Guid { get; set; }
        public string CashFlowId { get; set; }

        public virtual NaloziGk BrojNavigation { get; set; }
        public virtual CashFlowItems CashFlow { get; set; }
        public virtual AnalitickaKonta KontoNavigation { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinica { get; set; }
    }
}
