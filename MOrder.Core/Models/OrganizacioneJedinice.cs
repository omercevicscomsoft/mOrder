using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class OrganizacioneJedinice
    {
        public OrganizacioneJedinice()
        {
            Blagajne = new HashSet<Blagajne>();
            DokumentiAkcijaMp = new HashSet<DokumentiAkcijaMp>();
            DokumentiPrometaMpOrganizacionaJedinicaZaPrenosNavigation = new HashSet<DokumentiPrometaMp>();
            DokumentiPrometaMpSifraOrganizacioneJediniceNavigation = new HashSet<DokumentiPrometaMp>();
            DokumentiPrometaRepromaterijalaOrganizacionaJedinica = new HashSet<DokumentiPrometaRepromaterijala>();
            DokumentiPrometaRepromaterijalaSkladiste = new HashSet<DokumentiPrometaRepromaterijala>();
            DokumentiPrometaVpOrganizacionaJedinica = new HashSet<DokumentiPrometaVp>();
            DokumentiPrometaVpSkladiste = new HashSet<DokumentiPrometaVp>();
            KalkulacijeMpSifraOjNavigation = new HashSet<KalkulacijeMp>();
            KalkulacijeMpSifraOjdonosaNavigation = new HashSet<KalkulacijeMp>();
            KalkulacijeRepromaterijala = new HashSet<KalkulacijeRepromaterijala>();
            KalkulacijeRepromaterijalaZavisniTroskovi = new HashSet<KalkulacijeRepromaterijalaZavisniTroskovi>();
            KalkulacijeVpSifraOjNavigation = new HashSet<KalkulacijeVp>();
            KalkulacijeVpSifraOjdonosaNavigation = new HashSet<KalkulacijeVp>();
            KalkulacijeZavisniTroskovi = new HashSet<KalkulacijeZavisniTroskovi>();
            Kase = new HashSet<Kase>();
            KnjizneObavijesti = new HashSet<KnjizneObavijesti>();
            NaloziKompenzacije = new HashSet<NaloziKompenzacije>();
            NarudzbeniceDobavljacu = new HashSet<NarudzbeniceDobavljacu>();
            NarudzbeniceKupca = new HashSet<NarudzbeniceKupca>();
            ObrazacSl2 = new HashSet<ObrazacSl2>();
            OtpremniceVeleprodajeUtoku = new HashSet<OtpremniceVeleprodajeUtoku>();
            PomocnePopisneListe = new HashSet<PomocnePopisneListe>();
            PomocnePopisneListeRepromaterijala = new HashSet<PomocnePopisneListeRepromaterijala>();
            PomocnePopisneListeVp = new HashSet<PomocnePopisneListeVp>();
            PresjeciStanjaMp = new HashSet<PresjeciStanjaMp>();
            PridruzenaKonta = new HashSet<PridruzenaKonta>();
            PridruzeneGrupeNaloga = new HashSet<PridruzeneGrupeNaloga>();
            PripremljeniRacuni = new HashSet<PripremljeniRacuni>();
            PrometDobavljaca = new HashSet<PrometDobavljaca>();
            PrometGk = new HashSet<PrometGk>();
            PrometKupca = new HashSet<PrometKupca>();
            RacuniVp = new HashSet<RacuniVp>();
            RadniNalogMpSifraOjNavigation = new HashSet<RadniNalogMp>();
            RadniNalogMpSifraVeleprodajneOjNavigation = new HashSet<RadniNalogMp>();
            RadniNalogProizvodnjeSkladiste = new HashSet<RadniNalogProizvodnje>();
            RadniNalogProizvodnjeTrgovackoSkladisteNavigation = new HashSet<RadniNalogProizvodnje>();
            StavkeKalkulacijeRepromaterijala = new HashSet<StavkeKalkulacijeRepromaterijala>();
            StavkeKalkulacijeVp = new HashSet<StavkeKalkulacijeVp>();
            StavkeKnjiznihObavijesti = new HashSet<StavkeKnjiznihObavijesti>();
            StavkeNarudzbeniceDobavljacu = new HashSet<StavkeNarudzbeniceDobavljacu>();
            StavkePrometaMp = new HashSet<StavkePrometaMp>();
            StavkeRacunaVpSifraOjNavigation = new HashSet<StavkeRacunaVp>();
            StavkeRacunaVpSifraOjstavkeOtpremniceNavigation = new HashSet<StavkeRacunaVp>();
            TrgovackaKnjigaMaloprodaje = new HashSet<TrgovackaKnjigaMaloprodaje>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string SifraOpstina { get; set; }
        public string Adresa { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ZaokruzenjeProdajneCijene { get; set; }
        public string PretragaArtikla { get; set; }
        public string KontoZaliha { get; set; }
        public string KontoRuc { get; set; }
        public string KontoUkalkulisaniPdv { get; set; }
        public string KontoZavisniTrosak { get; set; }
        public string KontoDomaciDobavljac { get; set; }
        public string KontoInostraniDobavljac { get; set; }
        public string KontoDomaciKupac { get; set; }
        public string KontoInostraniKupac { get; set; }
        public string GrupaNalogaKalkulacija { get; set; }
        public string GrupaNalogaRacun { get; set; }
        public string KontoUlazniPdvdomaci { get; set; }
        public string KontoUlazniPdvinostrani { get; set; }
        public string KontoPazarGotovina { get; set; }
        public string KontoPazarKartica { get; set; }
        public string KontoPazarCek { get; set; }
        public string KontoPazarVirman { get; set; }
        public string KontoTrosakOdNabave { get; set; }
        public string KontoPrihodOdProdajeRobe { get; set; }
        public string KontoPrihodOdProdajeUsluga { get; set; }
        public string KontoRealiziraniPdv { get; set; }
        public string KontoOtpis { get; set; }
        public string KontoAkciza { get; set; }
        public string GrupaNalogaGotovinskeProdaje { get; set; }
        public string GrupaNalogaZapisnika { get; set; }
        public string GrupaNalogaOtipsDoDozvoljenogIznosa { get; set; }
        public string GrupaNalogaOtpisPrekoDozvoljenogIznosa { get; set; }
        public string Vrsta { get; set; }
        public bool PratiSerijeLijekova { get; set; }
        public string IzlazIzVp { get; set; }
        public int NacinKnjizenjaRacuna { get; set; }
        public string GrupaNalogaKompenzacije { get; set; }
        public bool DozvoljenoViseCijenaUmaloprodaji { get; set; }
        public string KontoRealiziraniPdvneobveznik { get; set; }
        public string GrupaNalogaKnjiznaObavijestKupci { get; set; }
        public string GrupaNalogaKnjiznaObavijestDobavljaci { get; set; }

        public virtual GrupeNalogaGk GrupaNalogaGotovinskeProdajeNavigation { get; set; }
        public virtual GrupeNalogaGk GrupaNalogaKalkulacijaNavigation { get; set; }
        public virtual GrupeNalogaGk GrupaNalogaKnjiznaObavijestDobavljaciNavigation { get; set; }
        public virtual GrupeNalogaGk GrupaNalogaKnjiznaObavijestKupciNavigation { get; set; }
        public virtual GrupeNalogaGk GrupaNalogaKompenzacijeNavigation { get; set; }
        public virtual GrupeNalogaGk GrupaNalogaOtipsDoDozvoljenogIznosaNavigation { get; set; }
        public virtual GrupeNalogaGk GrupaNalogaOtpisPrekoDozvoljenogIznosaNavigation { get; set; }
        public virtual GrupeNalogaGk GrupaNalogaRacunNavigation { get; set; }
        public virtual GrupeNalogaGk GrupaNalogaZapisnikaNavigation { get; set; }
        public virtual AnalitickaKonta KontoAkcizaNavigation { get; set; }
        public virtual AnalitickaKonta KontoDomaciDobavljacNavigation { get; set; }
        public virtual AnalitickaKonta KontoDomaciKupacNavigation { get; set; }
        public virtual AnalitickaKonta KontoInostraniDobavljacNavigation { get; set; }
        public virtual AnalitickaKonta KontoInostraniKupacNavigation { get; set; }
        public virtual AnalitickaKonta KontoOtpisNavigation { get; set; }
        public virtual AnalitickaKonta KontoPazarCekNavigation { get; set; }
        public virtual AnalitickaKonta KontoPazarGotovinaNavigation { get; set; }
        public virtual AnalitickaKonta KontoPazarKarticaNavigation { get; set; }
        public virtual AnalitickaKonta KontoPazarVirmanNavigation { get; set; }
        public virtual AnalitickaKonta KontoPrihodOdProdajeRobeNavigation { get; set; }
        public virtual AnalitickaKonta KontoPrihodOdProdajeUslugaNavigation { get; set; }
        public virtual AnalitickaKonta KontoRealiziraniPdvNavigation { get; set; }
        public virtual AnalitickaKonta KontoRealiziraniPdvneobveznikNavigation { get; set; }
        public virtual AnalitickaKonta KontoRucNavigation { get; set; }
        public virtual AnalitickaKonta KontoTrosakOdNabaveNavigation { get; set; }
        public virtual AnalitickaKonta KontoUkalkulisaniPdvNavigation { get; set; }
        public virtual AnalitickaKonta KontoUlazniPdvdomaciNavigation { get; set; }
        public virtual AnalitickaKonta KontoUlazniPdvinostraniNavigation { get; set; }
        public virtual AnalitickaKonta KontoZalihaNavigation { get; set; }
        public virtual AnalitickaKonta KontoZavisniTrosakNavigation { get; set; }
        public virtual Opcine SifraOpstinaNavigation { get; set; }
        public virtual ICollection<Blagajne> Blagajne { get; set; }
        public virtual ICollection<DokumentiAkcijaMp> DokumentiAkcijaMp { get; set; }
        public virtual ICollection<DokumentiPrometaMp> DokumentiPrometaMpOrganizacionaJedinicaZaPrenosNavigation { get; set; }
        public virtual ICollection<DokumentiPrometaMp> DokumentiPrometaMpSifraOrganizacioneJediniceNavigation { get; set; }
        public virtual ICollection<DokumentiPrometaRepromaterijala> DokumentiPrometaRepromaterijalaOrganizacionaJedinica { get; set; }
        public virtual ICollection<DokumentiPrometaRepromaterijala> DokumentiPrometaRepromaterijalaSkladiste { get; set; }
        public virtual ICollection<DokumentiPrometaVp> DokumentiPrometaVpOrganizacionaJedinica { get; set; }
        public virtual ICollection<DokumentiPrometaVp> DokumentiPrometaVpSkladiste { get; set; }
        public virtual ICollection<KalkulacijeMp> KalkulacijeMpSifraOjNavigation { get; set; }
        public virtual ICollection<KalkulacijeMp> KalkulacijeMpSifraOjdonosaNavigation { get; set; }
        public virtual ICollection<KalkulacijeRepromaterijala> KalkulacijeRepromaterijala { get; set; }
        public virtual ICollection<KalkulacijeRepromaterijalaZavisniTroskovi> KalkulacijeRepromaterijalaZavisniTroskovi { get; set; }
        public virtual ICollection<KalkulacijeVp> KalkulacijeVpSifraOjNavigation { get; set; }
        public virtual ICollection<KalkulacijeVp> KalkulacijeVpSifraOjdonosaNavigation { get; set; }
        public virtual ICollection<KalkulacijeZavisniTroskovi> KalkulacijeZavisniTroskovi { get; set; }
        public virtual ICollection<Kase> Kase { get; set; }
        public virtual ICollection<KnjizneObavijesti> KnjizneObavijesti { get; set; }
        public virtual ICollection<NaloziKompenzacije> NaloziKompenzacije { get; set; }
        public virtual ICollection<NarudzbeniceDobavljacu> NarudzbeniceDobavljacu { get; set; }
        public virtual ICollection<NarudzbeniceKupca> NarudzbeniceKupca { get; set; }
        public virtual ICollection<ObrazacSl2> ObrazacSl2 { get; set; }
        public virtual ICollection<OtpremniceVeleprodajeUtoku> OtpremniceVeleprodajeUtoku { get; set; }
        public virtual ICollection<PomocnePopisneListe> PomocnePopisneListe { get; set; }
        public virtual ICollection<PomocnePopisneListeRepromaterijala> PomocnePopisneListeRepromaterijala { get; set; }
        public virtual ICollection<PomocnePopisneListeVp> PomocnePopisneListeVp { get; set; }
        public virtual ICollection<PresjeciStanjaMp> PresjeciStanjaMp { get; set; }
        public virtual ICollection<PridruzenaKonta> PridruzenaKonta { get; set; }
        public virtual ICollection<PridruzeneGrupeNaloga> PridruzeneGrupeNaloga { get; set; }
        public virtual ICollection<PripremljeniRacuni> PripremljeniRacuni { get; set; }
        public virtual ICollection<PrometDobavljaca> PrometDobavljaca { get; set; }
        public virtual ICollection<PrometGk> PrometGk { get; set; }
        public virtual ICollection<PrometKupca> PrometKupca { get; set; }
        public virtual ICollection<RacuniVp> RacuniVp { get; set; }
        public virtual ICollection<RadniNalogMp> RadniNalogMpSifraOjNavigation { get; set; }
        public virtual ICollection<RadniNalogMp> RadniNalogMpSifraVeleprodajneOjNavigation { get; set; }
        public virtual ICollection<RadniNalogProizvodnje> RadniNalogProizvodnjeSkladiste { get; set; }
        public virtual ICollection<RadniNalogProizvodnje> RadniNalogProizvodnjeTrgovackoSkladisteNavigation { get; set; }
        public virtual ICollection<StavkeKalkulacijeRepromaterijala> StavkeKalkulacijeRepromaterijala { get; set; }
        public virtual ICollection<StavkeKalkulacijeVp> StavkeKalkulacijeVp { get; set; }
        public virtual ICollection<StavkeKnjiznihObavijesti> StavkeKnjiznihObavijesti { get; set; }
        public virtual ICollection<StavkeNarudzbeniceDobavljacu> StavkeNarudzbeniceDobavljacu { get; set; }
        public virtual ICollection<StavkePrometaMp> StavkePrometaMp { get; set; }
        public virtual ICollection<StavkeRacunaVp> StavkeRacunaVpSifraOjNavigation { get; set; }
        public virtual ICollection<StavkeRacunaVp> StavkeRacunaVpSifraOjstavkeOtpremniceNavigation { get; set; }
        public virtual ICollection<TrgovackaKnjigaMaloprodaje> TrgovackaKnjigaMaloprodaje { get; set; }
    }
}
