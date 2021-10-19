using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class StavkeNaAkcijiMp
    {
        public int Id { get; set; }
        public string RedniBrojAkcije { get; set; }
        public string ArtiklId { get; set; }
        public decimal PostotakPopusta { get; set; }
        public decimal ProdajnaCijena { get; set; }
        public bool Aktivno { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Artikli Artikl { get; set; }
        public virtual DokumentiAkcijaMp RedniBrojAkcijeNavigation { get; set; }
    }
}
