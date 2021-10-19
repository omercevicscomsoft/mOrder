using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkaObrascaSl2
    {
        public int Id { get; set; }
        public string SifraOj { get; set; }
        public string RedniBroj { get; set; }
        public DateTime DatumRacuna { get; set; }
        public string BrojRacuna { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosPdv { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid Guid { get; set; }

        public virtual ObrazacSl2 ObrazacSl2 { get; set; }
    }
}
