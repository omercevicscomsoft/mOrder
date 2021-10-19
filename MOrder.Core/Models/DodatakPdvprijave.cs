using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class DodatakPdvprijave
    {
        public string Mjesec { get; set; }
        public DateTime DatumPdv { get; set; }
        public string Djelatnost { get; set; }
        public int Isporuka1 { get; set; }
        public int Isporuka2 { get; set; }
        public int Isporuka3 { get; set; }
        public int Isporuka4 { get; set; }
        public int Isporuka5 { get; set; }
        public int Isporuka6 { get; set; }
        public int Isporuka8 { get; set; }
        public int Isporuka9 { get; set; }
        public int IsporukaPdv6 { get; set; }
        public int IsporukaPdv7 { get; set; }
        public int IsporukaPdv8 { get; set; }
        public int IsporukaPdv9 { get; set; }
        public int IsporukaPdv10 { get; set; }
        public int Nabavka1 { get; set; }
        public int Nabavka2 { get; set; }
        public int Nabavka3 { get; set; }
        public int Nabavka4 { get; set; }
        public int Nabavka5 { get; set; }
        public int Nabavka6 { get; set; }
        public int Nabavka8 { get; set; }
        public int NabavkaPdv2 { get; set; }
        public int NabavkaPdv3 { get; set; }
        public int NabavkaPdv4 { get; set; }
        public int NabavkaPdv5 { get; set; }
        public int NabavkaPdv6 { get; set; }
        public int NabavkaPdv7 { get; set; }
        public int NabavkaPdv8 { get; set; }
        public int NabavkaPdv9 { get; set; }
        public int Zaliha { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Djelatnosti DjelatnostNavigation { get; set; }
    }
}
