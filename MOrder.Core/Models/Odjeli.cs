using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Odjeli
    {
        public Odjeli()
        {
            DokumentiPrometaMp = new HashSet<DokumentiPrometaMp>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<DokumentiPrometaMp> DokumentiPrometaMp { get; set; }
    }
}
