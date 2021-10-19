using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Usluge
    {
        public string SifraUsluge { get; set; }
        public string NazivUsluge { get; set; }
        public string JedinicaMjere { get; set; }
        public string SifraPorezneGrupe { get; set; }
        public string SifraGrupeUsluga { get; set; }
        public decimal CijenaUsluge { get; set; }
        public string NacinObracunaPdva { get; set; }
        public string KataloskaOznaka { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual GrupeUsluga SifraGrupeUslugaNavigation { get; set; }
        public virtual PorezneGrupe SifraPorezneGrupeNavigation { get; set; }
    }
}
