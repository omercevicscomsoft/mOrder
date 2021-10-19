using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class ArtikliKalkulacijeMp
    {
        public int Id { get; set; }
        public string SifraOj { get; set; }
        public string BrojKalkulacije { get; set; }
        public string SifraArtikla { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal Marza { get; set; }
        public decimal Rabat1 { get; set; }
        public decimal Rabat2 { get; set; }
        public decimal ZavisniTrosak { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual KalkulacijeMp KalkulacijeMp { get; set; }
        public virtual Artikli SifraArtiklaNavigation { get; set; }
    }
}
