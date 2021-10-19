using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkeNarudzbeniceKupca
    {
        public string KomercijalistaId { get; set; }
        public string BrojNarudzbenice { get; set; }
        public int Id { get; set; }
        public string ArtiklId { get; set; }
        public decimal KolicinaNaruceno { get; set; }
        public decimal KolicinaIsporuceno { get; set; }
        public string OpisStavke { get; set; }
        public decimal VeleprodajnaCijena { get; set; }
        public DateTime? RokTrajanja { get; set; }
        public string BrojSerije { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string KomercijalistaSifra { get; set; }

        public virtual Artikli Artikl { get; set; }
        public virtual Komercijalisti KomercijalistaSifraNavigation { get; set; }
        public virtual NarudzbeniceKupca NarudzbeniceKupca { get; set; }
    }
}
