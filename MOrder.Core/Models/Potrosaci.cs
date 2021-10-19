using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Potrosaci
    {
        public Potrosaci()
        {
            DokumentiPrometaMp = new HashSet<DokumentiPrometaMp>();
            PrometPotrosaca = new HashSet<PrometPotrosaca>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string PttBroj { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumPrijave { get; set; }
        public DateTime? DatumOdjave { get; set; }
        public string Telefon { get; set; }
        public string Mobitel { get; set; }
        public string Email { get; set; }
        public bool EmailSubscriber { get; set; }
        public string Napomena { get; set; }
        public decimal PostotakPopusta { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool Aktivan { get; set; }

        public virtual Mjesta PttBrojNavigation { get; set; }
        public virtual ICollection<DokumentiPrometaMp> DokumentiPrometaMp { get; set; }
        public virtual ICollection<PrometPotrosaca> PrometPotrosaca { get; set; }
    }
}
