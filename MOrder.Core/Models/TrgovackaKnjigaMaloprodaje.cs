using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class TrgovackaKnjigaMaloprodaje
    {
        public string RedniBroj { get; set; }
        public string SifraOj { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public decimal Zaduzenje { get; set; }
        public decimal Razduzenje { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string BrojDokumenta { get; set; }
        public string SifraPoslovnogPartnera { get; set; }

        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual PoslovniPartneri SifraPoslovnogPartneraNavigation { get; set; }
    }
}
