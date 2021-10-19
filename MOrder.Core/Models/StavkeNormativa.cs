using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class StavkeNormativa
    {
        public int Id { get; set; }
        public string GotovProizvodId { get; set; }
        public string RepromaterijalId { get; set; }
        public string Opis { get; set; }
        public decimal Kolicina { get; set; }
        public decimal SkartPostotak { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Normativi GotovProizvod { get; set; }
        public virtual Repromaterijal Repromaterijal { get; set; }
    }
}
