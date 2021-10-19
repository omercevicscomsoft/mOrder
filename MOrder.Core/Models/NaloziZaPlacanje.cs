using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class NaloziZaPlacanje
    {
        public string NalogZaPlacanjeId { get; set; }
        public string Opis { get; set; }
        public bool ZaUplatuJavnihPrihoda { get; set; }
        public string UplatilacPrviRed { get; set; }
        public string UplatilacDrugiRed { get; set; }
        public string SvrhaDoznakePrviRed { get; set; }
        public string SvrhaDoznakeDrugiRed { get; set; }
        public string SvrhaDoznakeTreciRed { get; set; }
        public string PrimalacPrviRed { get; set; }
        public string PrimalacDrugiRed { get; set; }
        public string PrimalacTreciRed { get; set; }
        public string MjestoUplate { get; set; }
        public DateTime DatumUplate { get; set; }
        public string RacunUplatioca { get; set; }
        public string RacunPrimaoca { get; set; }
        public decimal Iznos { get; set; }
        public bool Hitno { get; set; }
        public string BrojPoreznogObveznika { get; set; }
        public string VrstaUplate { get; set; }
        public string VrstaPrihoda { get; set; }
        public string Opcina { get; set; }
        public string PozivNaBroj { get; set; }
        public string BudzetskaOrganizacija { get; set; }
        public DateTime? PocetniDatumPoreznogPerioda { get; set; }
        public DateTime? KrajnjiDatumPoreznogPerioda { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
