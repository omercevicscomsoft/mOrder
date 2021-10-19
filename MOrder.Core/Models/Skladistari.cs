using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Skladistari
    {
        public Skladistari()
        {
            NarudzbeniceKupca = new HashSet<NarudzbeniceKupca>();
        }

        public string Sifra { get; set; }
        public string ImePrezime { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Aktivan { get; set; }
        public string Napomena { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<NarudzbeniceKupca> NarudzbeniceKupca { get; set; }
    }
}
