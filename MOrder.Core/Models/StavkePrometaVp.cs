using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkePrometaVp
    {
        public int Id { get; set; }
        public string SkladisteId { get; set; }
        public string VrstaPrometaId { get; set; }
        public string BrojDokumenta { get; set; }
        public string ArtiklId { get; set; }
        public decimal Kolicina { get; set; }
        public decimal NabavnaCijena { get; set; }
        public DateTime? RokTrajanja { get; set; }
        public string OpisPrometa { get; set; }
        public string BrojSerije { get; set; }
        public string BrojKontrolePrveSerije { get; set; }
        public string BrojKontroleSvakeSerije { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal VeleprodajnaCijena { get; set; }
        public decimal StaraVeleprodajnaCijena { get; set; }

        public virtual Artikli Artikl { get; set; }
        public virtual DokumentiPrometaVp DokumentiPrometaVp { get; set; }
    }
}
