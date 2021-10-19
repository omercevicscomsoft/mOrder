using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkeNalogaKompenzacije
    {
        public int Id { get; set; }
        public string SifraKompenzacije { get; set; }
        public int VrstaObaveze { get; set; }
        public string OpisKnjizenja { get; set; }
        public decimal Iznos { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SifraOj { get; set; }

        public virtual NaloziKompenzacije Sifra { get; set; }
    }
}
