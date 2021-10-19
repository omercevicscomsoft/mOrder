using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PrometPotrosaca
    {
        public int Id { get; set; }
        public string SifraPotrosaca { get; set; }
        public DateTime Datum { get; set; }
        public decimal Iznos { get; set; }
        public string VrstaPrometa { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Potrosaci SifraPotrosacaNavigation { get; set; }
    }
}
