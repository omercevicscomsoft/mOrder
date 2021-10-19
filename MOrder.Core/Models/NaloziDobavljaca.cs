using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class NaloziDobavljaca
    {
        public NaloziDobavljaca()
        {
            PrometDobavljaca = new HashSet<PrometDobavljaca>();
        }

        public string Broj { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<PrometDobavljaca> PrometDobavljaca { get; set; }
    }
}
