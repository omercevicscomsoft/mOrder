using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class Normativi
    {
        public Normativi()
        {
            StavkeNormativa = new HashSet<StavkeNormativa>();
        }

        public string GotovProizvodId { get; set; }
        public string OpisNormativa { get; set; }
        public decimal MaloprodajnaCijena { get; set; }
        public decimal VeleprodajnaCijena { get; set; }
        public decimal OpciTrosakProizvodnjePostotak { get; set; }
        public decimal OpciTrosakProizvodnjeIznos { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Artikli GotovProizvod { get; set; }
        public virtual ICollection<StavkeNormativa> StavkeNormativa { get; set; }
    }
}
