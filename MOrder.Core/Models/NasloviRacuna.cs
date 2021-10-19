using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class NasloviRacuna
    {
        public string VrstaRacunaId { get; set; }
        public string Naslov { get; set; }
        public string Potpisnici { get; set; }
        public string Footer { get; set; }
        public bool DefaultNaslov { get; set; }
        public bool DefaultPotpisnici { get; set; }
        public bool DefaultFooter { get; set; }
        public bool Aktivan { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string NaslovStorno { get; set; }
        public bool DefaultNaslovStorno { get; set; }
    }
}
