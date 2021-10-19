using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PoslovneJedinice
    {
        public PoslovneJedinice()
        {
            DokumentiPrometaVp = new HashSet<DokumentiPrometaVp>();
            NarudzbeniceKupca = new HashSet<NarudzbeniceKupca>();
        }

        public string Sifra { get; set; }
        public string SifraPp { get; set; }
        public string Naziv { get; set; }
        public string PttBroj { get; set; }
        public string Adresa { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Mjesta PttBrojNavigation { get; set; }
        public virtual PoslovniPartneri SifraPpNavigation { get; set; }
        public virtual ICollection<DokumentiPrometaVp> DokumentiPrometaVp { get; set; }
        public virtual ICollection<NarudzbeniceKupca> NarudzbeniceKupca { get; set; }
    }
}
