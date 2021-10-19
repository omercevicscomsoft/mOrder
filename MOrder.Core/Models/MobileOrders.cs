using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class MobileOrders
    {
        public MobileOrders()
        {
            MobileOrderItems = new HashSet<MobileOrderItems>();
        }

        public int Id { get; set; }
        public int StolId { get; set; }
        public DateTime DatumIvrijeme { get; set; }
        public string UserNameProdavaca { get; set; }
        public string DodatniOpis { get; set; }
        public int Status { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Prodavaci UserNameProdavacaNavigation { get; set; }
        public virtual ICollection<MobileOrderItems> MobileOrderItems { get; set; }
    }
}
