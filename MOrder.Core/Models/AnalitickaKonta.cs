using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class AnalitickaKonta
    {
        public AnalitickaKonta()
        {
            Blagajne = new HashSet<Blagajne>();
            GrupeArtikalaKontoPrihodaInostranoTrzisteNavigation = new HashSet<GrupeArtikala>();
            GrupeArtikalaKontoPrihodaNavigation = new HashSet<GrupeArtikala>();
            GrupeUslugaKontoPrihodaInostranoTrzisteNavigation = new HashSet<GrupeUsluga>();
            GrupeUslugaKontoPrihodaNavigation = new HashSet<GrupeUsluga>();
            KategorijePrometaDobavljaca = new HashSet<KategorijePrometaDobavljaca>();
            OrganizacioneJediniceKontoAkcizaNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoDomaciDobavljacNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoDomaciKupacNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoInostraniDobavljacNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoInostraniKupacNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoOtpisNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoPazarCekNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoPazarGotovinaNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoPazarKarticaNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoPazarVirmanNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoPrihodOdProdajeRobeNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoPrihodOdProdajeUslugaNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoRealiziraniPdvNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoRealiziraniPdvneobveznikNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoRucNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoTrosakOdNabaveNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoUkalkulisaniPdvNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoUlazniPdvdomaciNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoUlazniPdvinostraniNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoZalihaNavigation = new HashSet<OrganizacioneJedinice>();
            OrganizacioneJediniceKontoZavisniTrosakNavigation = new HashSet<OrganizacioneJedinice>();
            PorezneGrupeKontoUlazniPdvdomaciNavigation = new HashSet<PorezneGrupe>();
            PorezneGrupeKontoUlazniPdvuvozNavigation = new HashSet<PorezneGrupe>();
            PredlosciPrometaBlagajne = new HashSet<PredlosciPrometaBlagajne>();
            PridruzenaKonta = new HashSet<PridruzenaKonta>();
            PrometGk = new HashSet<PrometGk>();
            PrometiBlagajne = new HashSet<PrometiBlagajne>();
            ShemaZatvaranjaKlasa = new HashSet<ShemaZatvaranjaKlasa>();
            TakseKontoObavezeNavigation = new HashSet<Takse>();
            TakseKontoRealiziraniPdvNeobveznicimaNavigation = new HashSet<Takse>();
            TakseKontoRealiziraniPdvObveznicimaNavigation = new HashSet<Takse>();
            TakseKontoUkalkulisaneTakseNavigation = new HashSet<Takse>();
            ZavisniTroskovi = new HashSet<ZavisniTroskovi>();
        }

        public string Konto { get; set; }
        public string Naziv { get; set; }
        public string Aop { get; set; }
        public bool? IspravkaVrijednosti { get; set; }
        public decimal? PlanskiIznos { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string VezaSaPrometomPertnera { get; set; }

        public virtual ICollection<Blagajne> Blagajne { get; set; }
        public virtual ICollection<GrupeArtikala> GrupeArtikalaKontoPrihodaInostranoTrzisteNavigation { get; set; }
        public virtual ICollection<GrupeArtikala> GrupeArtikalaKontoPrihodaNavigation { get; set; }
        public virtual ICollection<GrupeUsluga> GrupeUslugaKontoPrihodaInostranoTrzisteNavigation { get; set; }
        public virtual ICollection<GrupeUsluga> GrupeUslugaKontoPrihodaNavigation { get; set; }
        public virtual ICollection<KategorijePrometaDobavljaca> KategorijePrometaDobavljaca { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoAkcizaNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoDomaciDobavljacNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoDomaciKupacNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoInostraniDobavljacNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoInostraniKupacNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoOtpisNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoPazarCekNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoPazarGotovinaNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoPazarKarticaNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoPazarVirmanNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoPrihodOdProdajeRobeNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoPrihodOdProdajeUslugaNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoRealiziraniPdvNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoRealiziraniPdvneobveznikNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoRucNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoTrosakOdNabaveNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoUkalkulisaniPdvNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoUlazniPdvdomaciNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoUlazniPdvinostraniNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoZalihaNavigation { get; set; }
        public virtual ICollection<OrganizacioneJedinice> OrganizacioneJediniceKontoZavisniTrosakNavigation { get; set; }
        public virtual ICollection<PorezneGrupe> PorezneGrupeKontoUlazniPdvdomaciNavigation { get; set; }
        public virtual ICollection<PorezneGrupe> PorezneGrupeKontoUlazniPdvuvozNavigation { get; set; }
        public virtual ICollection<PredlosciPrometaBlagajne> PredlosciPrometaBlagajne { get; set; }
        public virtual ICollection<PridruzenaKonta> PridruzenaKonta { get; set; }
        public virtual ICollection<PrometGk> PrometGk { get; set; }
        public virtual ICollection<PrometiBlagajne> PrometiBlagajne { get; set; }
        public virtual ICollection<ShemaZatvaranjaKlasa> ShemaZatvaranjaKlasa { get; set; }
        public virtual ICollection<Takse> TakseKontoObavezeNavigation { get; set; }
        public virtual ICollection<Takse> TakseKontoRealiziraniPdvNeobveznicimaNavigation { get; set; }
        public virtual ICollection<Takse> TakseKontoRealiziraniPdvObveznicimaNavigation { get; set; }
        public virtual ICollection<Takse> TakseKontoUkalkulisaneTakseNavigation { get; set; }
        public virtual ICollection<ZavisniTroskovi> ZavisniTroskovi { get; set; }
    }
}
