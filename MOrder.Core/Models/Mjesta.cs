using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class Mjesta
    {
        public Mjesta()
        {
            Firma = new HashSet<Firma>();
            PoslovneJedinice = new HashSet<PoslovneJedinice>();
            PoslovniPartneri = new HashSet<PoslovniPartneri>();
            Potrosaci = new HashSet<Potrosaci>();
        }

        public string PttBroj { get; set; }
        public string Naziv { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Firma> Firma { get; set; }
        public virtual ICollection<PoslovneJedinice> PoslovneJedinice { get; set; }
        public virtual ICollection<PoslovniPartneri> PoslovniPartneri { get; set; }
        public virtual ICollection<Potrosaci> Potrosaci { get; set; }
    }
}
