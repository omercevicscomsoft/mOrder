using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class StraniDrzavljani
    {
        public StraniDrzavljani()
        {
            ObrazacSl2 = new HashSet<ObrazacSl2>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string BrojPutneIsprave { get; set; }
        public string Drzava { get; set; }
        public string Adresa { get; set; }
        public string Mjesto { get; set; }
        public string BankovniRacun { get; set; }
        public string NazivBanke { get; set; }
        public string Napomena { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Drzave DrzavaNavigation { get; set; }
        public virtual ICollection<ObrazacSl2> ObrazacSl2 { get; set; }
    }
}
