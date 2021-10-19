using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Korespondencija
    {
        public int Id { get; set; }
        public string SifraPoslovnogPartnera { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public string KontaktOsoba { get; set; }
        public DateTime? DogovoreniDatum { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual PoslovniPartneri SifraPoslovnogPartneraNavigation { get; set; }
    }
}
