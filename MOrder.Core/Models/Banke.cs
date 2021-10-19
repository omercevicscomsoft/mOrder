using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class Banke
    {
        public Banke()
        {
            BankePp = new HashSet<BankePp>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Racun { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Iban { get; set; }
        public string Swift { get; set; }
        public string RacunBanke { get; set; }

        public virtual ICollection<BankePp> BankePp { get; set; }
    }
}
