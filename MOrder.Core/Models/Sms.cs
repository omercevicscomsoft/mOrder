using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class Sms
    {
        public int Id { get; set; }
        public string Tekst { get; set; }
        public string Tip { get; set; }
        public string Primalac { get; set; }
        public string PrimalacImePrezime { get; set; }
        public string Posiljalac { get; set; }
        public string KorisnikImePrezime { get; set; }
        public DateTime? Datum { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
