using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Prodavaci
    {
        public Prodavaci()
        {
            DokumentiPrometaMp = new HashSet<DokumentiPrometaMp>();
            MobileOrders = new HashSet<MobileOrders>();
        }

        public string UserName { get; set; }
        public string Ime { get; set; }
        public string Password { get; set; }
        public string NaslovIspredImena { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool Aktivan { get; set; }
        public bool DozvoljenaPromjenaCijene { get; set; }
        public bool DozvoljenaPromjenaPostotka { get; set; }
        public int VrijemeZaOdjavu { get; set; }
        public bool DozvoljenaPromjenaKolicine { get; set; }
        public bool DozvoljenoZakljucenjeKase { get; set; }
        public bool DozvoljenPristupBackOffice { get; set; }
        public bool UvidUnezatvoreneRacunePrethodnogDana { get; set; }
        public bool UvidUnezatvoreneRacuneOstalihProdavaca { get; set; }

        public virtual ICollection<DokumentiPrometaMp> DokumentiPrometaMp { get; set; }
        public virtual ICollection<MobileOrders> MobileOrders { get; set; }
    }
}
