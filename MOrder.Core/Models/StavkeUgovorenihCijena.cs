using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkeUgovorenihCijena
    {
        public int Id { get; set; }
        public string SifraUgovoreneCijene { get; set; }
        public string ArtiklId { get; set; }
        public decimal CijenaUgovorena { get; set; }
        public decimal PopustUgovoren { get; set; }
        public bool Aktivan { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal CijenaUgovorenaMaloprodaja { get; set; }
        public decimal PopustUgovorenMaloprodaja { get; set; }

        public virtual Artikli Artikl { get; set; }
        public virtual UgovoreneCijene SifraUgovoreneCijeneNavigation { get; set; }
    }
}
