using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class NarudzbeniceKupca
    {
        public NarudzbeniceKupca()
        {
            StavkeNarudzbeniceKupca = new HashSet<StavkeNarudzbeniceKupca>();
        }

        public string KomercijalistaId { get; set; }
        public string BrojNarudzbenice { get; set; }
        public string KupacId { get; set; }
        public string PoslovnaJedinicaId { get; set; }
        public string OrganizacionaJedinicaId { get; set; }
        public DateTime DatumNarudzbenice { get; set; }
        public string OpisNarudzbenice { get; set; }
        public string OsobaZaKontakt { get; set; }
        public string Telefon { get; set; }
        public bool Isporuceno { get; set; }
        public DateTime? DatumIsporuke { get; set; }
        public string OpisIsporuke { get; set; }
        public bool Fakturisano { get; set; }
        public DateTime? DatumFakture { get; set; }
        public string BrojFakture { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SkladistarId { get; set; }
        public bool KupcevPrevoz { get; set; }
        public bool PotrebanPredracun { get; set; }
        public bool Odobreno { get; set; }
        public string Odobrio { get; set; }

        public virtual Komercijalisti Komercijalista { get; set; }
        public virtual PoslovniPartneri Kupac { get; set; }
        public virtual OrganizacioneJedinice OrganizacionaJedinica { get; set; }
        public virtual PoslovneJedinice PoslovneJedinice { get; set; }
        public virtual Skladistari Skladistar { get; set; }
        public virtual ICollection<StavkeNarudzbeniceKupca> StavkeNarudzbeniceKupca { get; set; }
    }
}
