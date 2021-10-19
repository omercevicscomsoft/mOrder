using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Drzave
    {
        public Drzave()
        {
            Artikli = new HashSet<Artikli>();
            PoslovniPartneri = new HashSet<PoslovniPartneri>();
            Repromaterijal = new HashSet<Repromaterijal>();
            StraniDrzavljani = new HashSet<StraniDrzavljani>();
        }

        public string Sifra { get; set; }
        public string NumerickaOznaka { get; set; }
        public string OznakaDrzave { get; set; }
        public string NazivDrzave { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Artikli> Artikli { get; set; }
        public virtual ICollection<PoslovniPartneri> PoslovniPartneri { get; set; }
        public virtual ICollection<Repromaterijal> Repromaterijal { get; set; }
        public virtual ICollection<StraniDrzavljani> StraniDrzavljani { get; set; }
    }
}
