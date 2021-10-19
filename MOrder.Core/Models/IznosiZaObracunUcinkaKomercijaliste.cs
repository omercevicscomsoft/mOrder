using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class IznosiZaObracunUcinkaKomercijaliste
    {
        public int Id { get; set; }
        public decimal Od { get; set; }
        public decimal Do { get; set; }
        public decimal Postotak { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
