using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class PodgrupeArtikala
    {
        public PodgrupeArtikala()
        {
            Artikli = new HashSet<Artikli>();
        }

        public string SifraGrupe { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual GrupeArtikala SifraGrupeNavigation { get; set; }
        public virtual ICollection<Artikli> Artikli { get; set; }
    }
}
