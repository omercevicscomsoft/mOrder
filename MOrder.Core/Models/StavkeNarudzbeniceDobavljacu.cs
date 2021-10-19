using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class StavkeNarudzbeniceDobavljacu
    {
        public string OrganizacionaJedinicaId { get; set; }
        public string Broj { get; set; }
        public int Id { get; set; }
        public string VrstaStavkeNarudzbenice { get; set; }
        public string ArtiklId { get; set; }
        public string NazivArtikla { get; set; }
        public string JedinicaMjere { get; set; }
        public decimal Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public string PoreznaGrupaId { get; set; }
        public string NacinObracunaPdva { get; set; }
        public string BarCode { get; set; }
        public string KataloskiBroj { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual NarudzbeniceDobavljacu NarudzbeniceDobavljacu { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinica { get; set; }
        public virtual PorezneGrupe PoreznaGrupa { get; set; }
    }
}
