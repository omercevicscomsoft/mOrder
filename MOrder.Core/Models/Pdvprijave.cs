using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class Pdvprijave
    {
        public string Mjesec { get; set; }
        public DateTime DatumPdv { get; set; }
        public decimal OporeziveIsporuke11 { get; set; }
        public decimal IzvozneIsporuke12 { get; set; }
        public decimal OslobodjenoPdv13 { get; set; }
        public decimal StandardneNabavke21 { get; set; }
        public decimal UvozneNabavke22 { get; set; }
        public decimal NabavkeOdPoljoprivrednika23 { get; set; }
        public decimal IzlazniPdv51 { get; set; }
        public decimal UlazniPdv41 { get; set; }
        public decimal UlazniPdvnaUvoz42 { get; set; }
        public decimal UlazniPdvpausal43 { get; set; }
        public bool Povrat { get; set; }
        public decimal KrajnjaPotrosnjaFbiH32 { get; set; }
        public decimal KrajnjaPotrosnjaRs33 { get; set; }
        public decimal KrajnjaPotrosnjaBrcko34 { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
