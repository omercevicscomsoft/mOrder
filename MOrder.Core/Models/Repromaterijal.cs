using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Repromaterijal
    {
        public Repromaterijal()
        {
            KalkulacijeRepromaterijalaZavisniTroskovi = new HashSet<KalkulacijeRepromaterijalaZavisniTroskovi>();
            PomocnePopisneListeRepromaterijala = new HashSet<PomocnePopisneListeRepromaterijala>();
            StavkeKalkulacijeRepromaterijala = new HashSet<StavkeKalkulacijeRepromaterijala>();
            StavkeNormativa = new HashSet<StavkeNormativa>();
            StavkePrometaRepromaterijala = new HashSet<StavkePrometaRepromaterijala>();
        }

        public string RepromaterijalId { get; set; }
        public string Naziv { get; set; }
        public string JedinicaMjere { get; set; }
        public string PoreznaGrupaId { get; set; }
        public string GrupaArtikalaId { get; set; }
        public string BarCode { get; set; }
        public decimal MinimalnaZaliha { get; set; }
        public decimal MaksimalnaZaliha { get; set; }
        public string KataloskiBroj { get; set; }
        public string CarinskaTarifa { get; set; }
        public string KlasifikacijaId { get; set; }
        public string ProizvodjacId { get; set; }
        public decimal Tezina { get; set; }
        public string OpisPakovanja { get; set; }
        public bool Aktivan { get; set; }
        public decimal Cijena { get; set; }
        public decimal PostotakDozvoljenogOtpisa { get; set; }
        public string ZemljaPorijeklaId { get; set; }
        public string DobavljacId { get; set; }
        public string Opis { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual PoslovniPartneri Dobavljac { get; set; }
        public virtual GrupeArtikala GrupaArtikala { get; set; }
        public virtual Klasifikacije Klasifikacija { get; set; }
        public virtual PorezneGrupe PoreznaGrupa { get; set; }
        public virtual Proizvodjaci Proizvodjac { get; set; }
        public virtual Drzave ZemljaPorijekla { get; set; }
        public virtual ICollection<KalkulacijeRepromaterijalaZavisniTroskovi> KalkulacijeRepromaterijalaZavisniTroskovi { get; set; }
        public virtual ICollection<PomocnePopisneListeRepromaterijala> PomocnePopisneListeRepromaterijala { get; set; }
        public virtual ICollection<StavkeKalkulacijeRepromaterijala> StavkeKalkulacijeRepromaterijala { get; set; }
        public virtual ICollection<StavkeNormativa> StavkeNormativa { get; set; }
        public virtual ICollection<StavkePrometaRepromaterijala> StavkePrometaRepromaterijala { get; set; }
    }
}
