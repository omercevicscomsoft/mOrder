using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class GotoviProizvodiRadnogNalogaProizvodnje
    {
        public string BrojRadnogNaloga { get; set; }
        public string SifraGotovogProizvoda { get; set; }
        public decimal Kolicina { get; set; }
        public decimal ProdajnaCijena { get; set; }
        public string NacinObracunaPdv { get; set; }
        public string Boja { get; set; }
        public string NacinPakovanja { get; set; }
        public string Opis { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int Id { get; set; }
        public decimal ProizvodnaCijena { get; set; }

        public virtual RadniNalogProizvodnje BrojRadnogNalogaNavigation { get; set; }
        public virtual Artikli SifraGotovogProizvodaNavigation { get; set; }
    }
}
