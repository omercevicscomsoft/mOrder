using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Kuf
    {
        public Kuf()
        {
            KufUvoz = new HashSet<KufUvoz>();
        }

        public string RedniBroj { get; set; }
        public string BrojFakture { get; set; }
        public DateTime DatumFakture { get; set; }
        public string SifraDobavljaca { get; set; }
        public string VrstaFakture { get; set; }
        public string VrstaDokumenta { get; set; }
        public string Opis { get; set; }
        public string MjesecObrade { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal UkupniIznos { get; set; }
        public decimal PausalnaNaknada { get; set; }
        public decimal IznosPdv { get; set; }
        public decimal PriznatiPdv { get; set; }
        public decimal NepriznatiPdv { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? Guid { get; set; }
        public bool DobavljacPdvObveznik { get; set; }
        public DateTime DatumPrijema { get; set; }
        public string BrojJci { get; set; }
        public DateTime? DatumJci { get; set; }
        public string TipDokumenta { get; set; }
        public string MjestoKrajnjePotrosnje { get; set; }

        public virtual PoslovniPartneri SifraDobavljacaNavigation { get; set; }
        public virtual ICollection<KufUvoz> KufUvoz { get; set; }
    }
}
