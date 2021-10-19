using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class BankePp
    {
        public int Id { get; set; }
        public string SifraPp { get; set; }
        public string SifraBanke { get; set; }
        public string BrojRacuna { get; set; }
        public bool Aktivan { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Banke SifraBankeNavigation { get; set; }
        public virtual PoslovniPartneri SifraPpNavigation { get; set; }
    }
}
