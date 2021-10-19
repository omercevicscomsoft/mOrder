using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class ShemaZatvaranjaKlasa
    {
        public int Id { get; set; }
        public string Konto { get; set; }
        public string Opis { get; set; }
        public string Klasa { get; set; }
        public string Strana { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual AnalitickaKonta KontoNavigation { get; set; }
    }
}
