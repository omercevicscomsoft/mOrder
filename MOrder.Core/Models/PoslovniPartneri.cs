using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class PoslovniPartneri
    {
        public PoslovniPartneri()
        {
            Artikli = new HashSet<Artikli>();
            BankePp = new HashSet<BankePp>();
            DokumentiPrometaMp = new HashSet<DokumentiPrometaMp>();
            DokumentiPrometaRepromaterijala = new HashSet<DokumentiPrometaRepromaterijala>();
            DokumentiPrometaVp = new HashSet<DokumentiPrometaVp>();
            KalkulacijeMp = new HashSet<KalkulacijeMp>();
            KalkulacijeRepromaterijala = new HashSet<KalkulacijeRepromaterijala>();
            KalkulacijeVp = new HashSet<KalkulacijeVp>();
            Kif = new HashSet<Kif>();
            KnjizneObavijesti = new HashSet<KnjizneObavijesti>();
            Korespondencija = new HashSet<Korespondencija>();
            Kuf = new HashSet<Kuf>();
            KufUvoz = new HashSet<KufUvoz>();
            NaloziKompenzacije = new HashSet<NaloziKompenzacije>();
            NarudzbeniceDobavljacu = new HashSet<NarudzbeniceDobavljacu>();
            NarudzbeniceKupca = new HashSet<NarudzbeniceKupca>();
            OtpremniceVeleprodajeUtoku = new HashSet<OtpremniceVeleprodajeUtoku>();
            PoslovneJedinice = new HashSet<PoslovneJedinice>();
            PredlosciPrometaBlagajne = new HashSet<PredlosciPrometaBlagajne>();
            PripremljeniRacuni = new HashSet<PripremljeniRacuni>();
            PrometDobavljaca = new HashSet<PrometDobavljaca>();
            PrometKupca = new HashSet<PrometKupca>();
            PrometiBlagajne = new HashSet<PrometiBlagajne>();
            RacuniVp = new HashSet<RacuniVp>();
            RadniNalogMp = new HashSet<RadniNalogMp>();
            RadniNalogProizvodnje = new HashSet<RadniNalogProizvodnje>();
            Repromaterijal = new HashSet<Repromaterijal>();
            TrgovackaKnjigaMaloprodaje = new HashSet<TrgovackaKnjigaMaloprodaje>();
            UgovoreneCijene = new HashSet<UgovoreneCijene>();
        }

        public string Sifra { get; set; }
        public bool Aktivan { get; set; }
        public string DomaciInostrani { get; set; }
        public string VrstaPoslovnogPartnera { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string MjestoId { get; set; }
        public string InostranoMjesto { get; set; }
        public string OpcinaId { get; set; }
        public string DrzavaId { get; set; }
        public string OblikOrganizacije { get; set; }
        public string Pdvbroj { get; set; }
        public string Idbroj { get; set; }
        public string Jmbg { get; set; }
        public bool Pdvstatus { get; set; }
        public string MjestoRegistracije { get; set; }
        public string RegistarskiBroj { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Mobitel { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Direktor { get; set; }
        public string KontaktOsoba { get; set; }
        public string BrojUgovoraOsuradnji { get; set; }
        public DateTime? DatumUgovoraOsuradnji { get; set; }
        public decimal UgovoreniRabat { get; set; }
        public int BrojDanaZaPlacanje { get; set; }
        public string Vlasnik { get; set; }
        public string SkraceniNaziv { get; set; }
        public string TekstNaNalogu1 { get; set; }
        public string TekstNaNalogu2 { get; set; }
        public string TekstNaNalogu3 { get; set; }
        public string AdresaNaRacunu1 { get; set; }
        public string AdresaNaRacunu2 { get; set; }
        public string AdresaNaRacunu3 { get; set; }
        public string Napomena { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool BillingAdress { get; set; }
        public string DjelatnostId { get; set; }
        public string AdresaNaRacunu4 { get; set; }
        public bool PovezanoLice { get; set; }
        public bool SendSms { get; set; }
        public bool SendEmail { get; set; }
        public string InostraniPdvbroj { get; set; }
        public string InostraniIdbroj { get; set; }
        public bool DozvoljenPopust { get; set; }
        public bool DozvoljenoZiralnoPlacanjeMp { get; set; }

        public virtual Djelatnosti Djelatnost { get; set; }
        public virtual Drzave Drzava { get; set; }
        public virtual Mjesta Mjesto { get; set; }
        public virtual OblikOrganizovanja OblikOrganizacijeNavigation { get; set; }
        public virtual Opcine Opcina { get; set; }
        public virtual ICollection<Artikli> Artikli { get; set; }
        public virtual ICollection<BankePp> BankePp { get; set; }
        public virtual ICollection<DokumentiPrometaMp> DokumentiPrometaMp { get; set; }
        public virtual ICollection<DokumentiPrometaRepromaterijala> DokumentiPrometaRepromaterijala { get; set; }
        public virtual ICollection<DokumentiPrometaVp> DokumentiPrometaVp { get; set; }
        public virtual ICollection<KalkulacijeMp> KalkulacijeMp { get; set; }
        public virtual ICollection<KalkulacijeRepromaterijala> KalkulacijeRepromaterijala { get; set; }
        public virtual ICollection<KalkulacijeVp> KalkulacijeVp { get; set; }
        public virtual ICollection<Kif> Kif { get; set; }
        public virtual ICollection<KnjizneObavijesti> KnjizneObavijesti { get; set; }
        public virtual ICollection<Korespondencija> Korespondencija { get; set; }
        public virtual ICollection<Kuf> Kuf { get; set; }
        public virtual ICollection<KufUvoz> KufUvoz { get; set; }
        public virtual ICollection<NaloziKompenzacije> NaloziKompenzacije { get; set; }
        public virtual ICollection<NarudzbeniceDobavljacu> NarudzbeniceDobavljacu { get; set; }
        public virtual ICollection<NarudzbeniceKupca> NarudzbeniceKupca { get; set; }
        public virtual ICollection<OtpremniceVeleprodajeUtoku> OtpremniceVeleprodajeUtoku { get; set; }
        public virtual ICollection<PoslovneJedinice> PoslovneJedinice { get; set; }
        public virtual ICollection<PredlosciPrometaBlagajne> PredlosciPrometaBlagajne { get; set; }
        public virtual ICollection<PripremljeniRacuni> PripremljeniRacuni { get; set; }
        public virtual ICollection<PrometDobavljaca> PrometDobavljaca { get; set; }
        public virtual ICollection<PrometKupca> PrometKupca { get; set; }
        public virtual ICollection<PrometiBlagajne> PrometiBlagajne { get; set; }
        public virtual ICollection<RacuniVp> RacuniVp { get; set; }
        public virtual ICollection<RadniNalogMp> RadniNalogMp { get; set; }
        public virtual ICollection<RadniNalogProizvodnje> RadniNalogProizvodnje { get; set; }
        public virtual ICollection<Repromaterijal> Repromaterijal { get; set; }
        public virtual ICollection<TrgovackaKnjigaMaloprodaje> TrgovackaKnjigaMaloprodaje { get; set; }
        public virtual ICollection<UgovoreneCijene> UgovoreneCijene { get; set; }
    }
}
