using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class Artikli
    {
        public Artikli()
        {
            ArtikliKalkulacijeMp = new HashSet<ArtikliKalkulacijeMp>();
            GotoviProizvodiRadnogNalogaProizvodnje = new HashSet<GotoviProizvodiRadnogNalogaProizvodnje>();
            KalkulacijeZavisniTroskovi = new HashSet<KalkulacijeZavisniTroskovi>();
            PomocnePopisneListe = new HashSet<PomocnePopisneListe>();
            PomocnePopisneListeVp = new HashSet<PomocnePopisneListeVp>();
            PresjeciStanjaMp = new HashSet<PresjeciStanjaMp>();
            StavkeKalkulacijeVp = new HashSet<StavkeKalkulacijeVp>();
            StavkeNaAkcijiMp = new HashSet<StavkeNaAkcijiMp>();
            StavkeNarudzbeniceKupca = new HashSet<StavkeNarudzbeniceKupca>();
            StavkePrometaMp = new HashSet<StavkePrometaMp>();
            StavkePrometaVp = new HashSet<StavkePrometaVp>();
            StavkeUgovorenihCijena = new HashSet<StavkeUgovorenihCijena>();
            Takse = new HashSet<Takse>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string JedinicaMjere { get; set; }
        public string SifraPorezneGrupe { get; set; }
        public string SifraGrupeArtikala { get; set; }
        public string BarCode { get; set; }
        public decimal MinimalnaZaliha { get; set; }
        public decimal MaksimalnaZaliha { get; set; }
        public string KataloskiBroj { get; set; }
        public string CarinskaTarifa { get; set; }
        public string SifraKlasifikacije { get; set; }
        public string SifraProizvodjaca { get; set; }
        public decimal Tezina { get; set; }
        public string OpisPakovanja { get; set; }
        public bool Aktivan { get; set; }
        public string VrstaArtikla { get; set; }
        public bool PovratPdv { get; set; }
        public decimal Cijena { get; set; }
        public int BrojMjeseciGarancije { get; set; }
        public bool DozvoljenPopust { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal MaksimalnaMarzaMp { get; set; }
        public decimal MaksimalnaMarzaVp { get; set; }
        public string ZemljaPorijekla { get; set; }
        public string Dobavljac { get; set; }
        public string SifraPodgrupeArtikala { get; set; }
        public byte[] Slika { get; set; }
        public bool Favorit { get; set; }
        public string Opis { get; set; }
        public string BarCode2 { get; set; }
        public decimal PopustApsolutniIznos { get; set; }
        public bool Vaga { get; set; }
        public bool ZaPos { get; set; }
        public string SifraOj { get; set; }
        public bool PosebanStatusMp { get; set; }
        public bool PosebanStatusVp { get; set; }
        public decimal DebljinaArtikla { get; set; }
        public bool PopustApsolutniIznosSamoUzPotrosaca { get; set; }

        public virtual PoslovniPartneri DobavljacNavigation { get; set; }
        public virtual GrupeArtikala SifraGrupeArtikalaNavigation { get; set; }
        public virtual Klasifikacije SifraKlasifikacijeNavigation { get; set; }
        public virtual PodgrupeArtikala SifraNavigation { get; set; }
        public virtual PorezneGrupe SifraPorezneGrupeNavigation { get; set; }
        public virtual Proizvodjaci SifraProizvodjacaNavigation { get; set; }
        public virtual Drzave ZemljaPorijeklaNavigation { get; set; }
        public virtual Normativi Normativi { get; set; }
        public virtual ICollection<ArtikliKalkulacijeMp> ArtikliKalkulacijeMp { get; set; }
        public virtual ICollection<GotoviProizvodiRadnogNalogaProizvodnje> GotoviProizvodiRadnogNalogaProizvodnje { get; set; }
        public virtual ICollection<KalkulacijeZavisniTroskovi> KalkulacijeZavisniTroskovi { get; set; }
        public virtual ICollection<PomocnePopisneListe> PomocnePopisneListe { get; set; }
        public virtual ICollection<PomocnePopisneListeVp> PomocnePopisneListeVp { get; set; }
        public virtual ICollection<PresjeciStanjaMp> PresjeciStanjaMp { get; set; }
        public virtual ICollection<StavkeKalkulacijeVp> StavkeKalkulacijeVp { get; set; }
        public virtual ICollection<StavkeNaAkcijiMp> StavkeNaAkcijiMp { get; set; }
        public virtual ICollection<StavkeNarudzbeniceKupca> StavkeNarudzbeniceKupca { get; set; }
        public virtual ICollection<StavkePrometaMp> StavkePrometaMp { get; set; }
        public virtual ICollection<StavkePrometaVp> StavkePrometaVp { get; set; }
        public virtual ICollection<StavkeUgovorenihCijena> StavkeUgovorenihCijena { get; set; }
        public virtual ICollection<Takse> Takse { get; set; }
    }
}
