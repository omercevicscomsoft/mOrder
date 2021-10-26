using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class hotelasi_2021Context : DbContext
    {
        public hotelasi_2021Context()
        {
        }

        public hotelasi_2021Context(DbContextOptions<hotelasi_2021Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AnalitickaKonta> AnalitickaKonta { get; set; }
        public virtual DbSet<Artikli> Artikli { get; set; }
        public virtual DbSet<ArtikliKalkulacijeMp> ArtikliKalkulacijeMp { get; set; }
        public virtual DbSet<Banke> Banke { get; set; }
        public virtual DbSet<BankePp> BankePp { get; set; }
        public virtual DbSet<Blagajne> Blagajne { get; set; }
        public virtual DbSet<CashFlowItems> CashFlowItems { get; set; }
        public virtual DbSet<Djelatnosti> Djelatnosti { get; set; }
        public virtual DbSet<DodatakPdvprijave> DodatakPdvprijave { get; set; }
        public virtual DbSet<Dokumenti> Dokumenti { get; set; }
        public virtual DbSet<DokumentiAkcijaMp> DokumentiAkcijaMp { get; set; }
        public virtual DbSet<DokumentiPrometaMp> DokumentiPrometaMp { get; set; }
        public virtual DbSet<DokumentiPrometaRepromaterijala> DokumentiPrometaRepromaterijala { get; set; }
        public virtual DbSet<DokumentiPrometaVp> DokumentiPrometaVp { get; set; }
        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<FiskalniPisaci> FiskalniPisaci { get; set; }
        public virtual DbSet<GotoviProizvodiRadnogNalogaProizvodnje> GotoviProizvodiRadnogNalogaProizvodnje { get; set; }
        public virtual DbSet<GrupaPripremljenihRacuna> GrupaPripremljenihRacuna { get; set; }
        public virtual DbSet<GrupeArtikala> GrupeArtikala { get; set; }
        public virtual DbSet<GrupeKonta> GrupeKonta { get; set; }
        public virtual DbSet<GrupeNalogaGk> GrupeNalogaGk { get; set; }
        public virtual DbSet<GrupeUsluga> GrupeUsluga { get; set; }
        public virtual DbSet<IznosiZaObracunUcinkaKomercijaliste> IznosiZaObracunUcinkaKomercijaliste { get; set; }
        public virtual DbSet<KalkulacijeMp> KalkulacijeMp { get; set; }
        public virtual DbSet<KalkulacijeRepromaterijala> KalkulacijeRepromaterijala { get; set; }
        public virtual DbSet<KalkulacijeRepromaterijalaZavisniTroskovi> KalkulacijeRepromaterijalaZavisniTroskovi { get; set; }
        public virtual DbSet<KalkulacijeVp> KalkulacijeVp { get; set; }
        public virtual DbSet<KalkulacijeZavisniTroskovi> KalkulacijeZavisniTroskovi { get; set; }
        public virtual DbSet<KamatniKalkulator> KamatniKalkulator { get; set; }
        public virtual DbSet<Kantoni> Kantoni { get; set; }
        public virtual DbSet<Kase> Kase { get; set; }
        public virtual DbSet<KategorijePrometaDobavljaca> KategorijePrometaDobavljaca { get; set; }
        public virtual DbSet<Kif> Kif { get; set; }
        public virtual DbSet<KlaseKonta> KlaseKonta { get; set; }
        public virtual DbSet<Klasifikacije> Klasifikacije { get; set; }
        public virtual DbSet<KnjizneObavijesti> KnjizneObavijesti { get; set; }
        public virtual DbSet<Komercijalisti> Komercijalisti { get; set; }
        public virtual DbSet<KontoZaPrelazUprometPps> KontoZaPrelazUprometPps { get; set; }
        public virtual DbSet<Korespondencija> Korespondencija { get; set; }
        public virtual DbSet<Kuf> Kuf { get; set; }
        public virtual DbSet<KufUvoz> KufUvoz { get; set; }
        public virtual DbSet<KursnaLista> KursnaLista { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Mjesta> Mjesta { get; set; }
        public virtual DbSet<MobileOrderItems> MobileOrderItems { get; set; }
        public virtual DbSet<MobileOrders> MobileOrders { get; set; }
        public virtual DbSet<NaljepnicaUroli> NaljepnicaUroli { get; set; }
        public virtual DbSet<NaloziBlagajne> NaloziBlagajne { get; set; }
        public virtual DbSet<NaloziDobavljaca> NaloziDobavljaca { get; set; }
        public virtual DbSet<NaloziGk> NaloziGk { get; set; }
        public virtual DbSet<NaloziKompenzacije> NaloziKompenzacije { get; set; }
        public virtual DbSet<NaloziKupca> NaloziKupca { get; set; }
        public virtual DbSet<NaloziZaPlacanje> NaloziZaPlacanje { get; set; }
        public virtual DbSet<NaloziZaPlacanjePrintOptionsDetail> NaloziZaPlacanjePrintOptionsDetail { get; set; }
        public virtual DbSet<NaloziZaPlacanjePrintOptionsMaster> NaloziZaPlacanjePrintOptionsMaster { get; set; }
        public virtual DbSet<NarudzbeniceDobavljacu> NarudzbeniceDobavljacu { get; set; }
        public virtual DbSet<NarudzbeniceKupca> NarudzbeniceKupca { get; set; }
        public virtual DbSet<NasloviRacuna> NasloviRacuna { get; set; }
        public virtual DbSet<Normativi> Normativi { get; set; }
        public virtual DbSet<OblikOrganizovanja> OblikOrganizovanja { get; set; }
        public virtual DbSet<ObrazacSl2> ObrazacSl2 { get; set; }
        public virtual DbSet<Odjeli> Odjeli { get; set; }
        public virtual DbSet<Opcine> Opcine { get; set; }
        public virtual DbSet<OrganizacioneJedinice> OrganizacioneJedinice { get; set; }
        public virtual DbSet<OtpremniceVeleprodajeUtoku> OtpremniceVeleprodajeUtoku { get; set; }
        public virtual DbSet<Pdvprijave> Pdvprijave { get; set; }
        public virtual DbSet<PodgrupeArtikala> PodgrupeArtikala { get; set; }
        public virtual DbSet<PodrucjeDjelatnosti> PodrucjeDjelatnosti { get; set; }
        public virtual DbSet<PomocnePopisneListe> PomocnePopisneListe { get; set; }
        public virtual DbSet<PomocnePopisneListeRepromaterijala> PomocnePopisneListeRepromaterijala { get; set; }
        public virtual DbSet<PomocnePopisneListeVp> PomocnePopisneListeVp { get; set; }
        public virtual DbSet<PorezneGrupe> PorezneGrupe { get; set; }
        public virtual DbSet<PosPostavke> PosPostavke { get; set; }
        public virtual DbSet<PoslovneJedinice> PoslovneJedinice { get; set; }
        public virtual DbSet<PoslovniPartneri> PoslovniPartneri { get; set; }
        public virtual DbSet<Pospisaci> Pospisaci { get; set; }
        public virtual DbSet<PostavkaIspisaKnjiznihObavijesti> PostavkaIspisaKnjiznihObavijesti { get; set; }
        public virtual DbSet<PostavkaIspisaRacuna> PostavkaIspisaRacuna { get; set; }
        public virtual DbSet<PostavkaIzvoznihRacuna> PostavkaIzvoznihRacuna { get; set; }
        public virtual DbSet<Postavke> Postavke { get; set; }
        public virtual DbSet<Potrosaci> Potrosaci { get; set; }
        public virtual DbSet<PovremeniKupci> PovremeniKupci { get; set; }
        public virtual DbSet<PredlosciPrometaBlagajne> PredlosciPrometaBlagajne { get; set; }
        public virtual DbSet<PresjeciStanjaMp> PresjeciStanjaMp { get; set; }
        public virtual DbSet<PridruzenaKonta> PridruzenaKonta { get; set; }
        public virtual DbSet<PridruzeneGrupeNaloga> PridruzeneGrupeNaloga { get; set; }
        public virtual DbSet<PrintedReports> PrintedReports { get; set; }
        public virtual DbSet<PripremljeniRacuni> PripremljeniRacuni { get; set; }
        public virtual DbSet<Prodavaci> Prodavaci { get; set; }
        public virtual DbSet<Proizvodjaci> Proizvodjaci { get; set; }
        public virtual DbSet<PrometDobavljaca> PrometDobavljaca { get; set; }
        public virtual DbSet<PrometGk> PrometGk { get; set; }
        public virtual DbSet<PrometKupca> PrometKupca { get; set; }
        public virtual DbSet<PrometPotrosaca> PrometPotrosaca { get; set; }
        public virtual DbSet<PrometiBlagajne> PrometiBlagajne { get; set; }
        public virtual DbSet<RacuniVp> RacuniVp { get; set; }
        public virtual DbSet<RadniNalogMp> RadniNalogMp { get; set; }
        public virtual DbSet<RadniNalogProizvodnje> RadniNalogProizvodnje { get; set; }
        public virtual DbSet<Regije> Regije { get; set; }
        public virtual DbSet<Repromaterijal> Repromaterijal { get; set; }
        public virtual DbSet<ShemaZatvaranjaKlasa> ShemaZatvaranjaKlasa { get; set; }
        public virtual DbSet<SintetickaKonta> SintetickaKonta { get; set; }
        public virtual DbSet<Skladistari> Skladistari { get; set; }
        public virtual DbSet<Sms> Sms { get; set; }
        public virtual DbSet<StavkaObrascaSl2> StavkaObrascaSl2 { get; set; }
        public virtual DbSet<StavkeBilansaStanja> StavkeBilansaStanja { get; set; }
        public virtual DbSet<StavkeBilansaUspjeha> StavkeBilansaUspjeha { get; set; }
        public virtual DbSet<StavkeKalkulacijeRepromaterijala> StavkeKalkulacijeRepromaterijala { get; set; }
        public virtual DbSet<StavkeKalkulacijeVp> StavkeKalkulacijeVp { get; set; }
        public virtual DbSet<StavkeKnjiznihObavijesti> StavkeKnjiznihObavijesti { get; set; }
        public virtual DbSet<StavkeNaAkcijiMp> StavkeNaAkcijiMp { get; set; }
        public virtual DbSet<StavkeNalogaKompenzacije> StavkeNalogaKompenzacije { get; set; }
        public virtual DbSet<StavkeNarudzbeniceDobavljacu> StavkeNarudzbeniceDobavljacu { get; set; }
        public virtual DbSet<StavkeNarudzbeniceKupca> StavkeNarudzbeniceKupca { get; set; }
        public virtual DbSet<StavkeNormativa> StavkeNormativa { get; set; }
        public virtual DbSet<StavkePrometaMp> StavkePrometaMp { get; set; }
        public virtual DbSet<StavkePrometaRepromaterijala> StavkePrometaRepromaterijala { get; set; }
        public virtual DbSet<StavkePrometaVp> StavkePrometaVp { get; set; }
        public virtual DbSet<StavkeRacunaVp> StavkeRacunaVp { get; set; }
        public virtual DbSet<StavkeUgovorenihCijena> StavkeUgovorenihCijena { get; set; }
        public virtual DbSet<StraniDrzavljani> StraniDrzavljani { get; set; }
        public virtual DbSet<Takse> Takse { get; set; }
        public virtual DbSet<Tekstovi> Tekstovi { get; set; }
        public virtual DbSet<TrgovackaKnjigaMaloprodaje> TrgovackaKnjigaMaloprodaje { get; set; }
        public virtual DbSet<UcescePeriodaNaplate> UcescePeriodaNaplate { get; set; }
        public virtual DbSet<UgovoreneCijene> UgovoreneCijene { get; set; }
        public virtual DbSet<Usluge> Usluge { get; set; }
        public virtual DbSet<ZavisniTroskovi> ZavisniTroskovi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SERVER-CS\\SQLSTANDARD;Initial Catalog=hotelasi_2021;Integrated Security=False;User ID=korisnik;Password=korisnik;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnalitickaKonta>(entity =>
            {
                entity.HasKey(e => e.Konto)
                    .HasName("PK_dbo.AnalitickaKonta");

                entity.Property(e => e.Konto)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Aop)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PlanskiIznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VezaSaPrometomPertnera)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('2')");
            });

            modelBuilder.Entity<Artikli>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Artikli");

                entity.HasIndex(e => e.Dobavljac)
                    .HasName("IX_Dobavljac");

                entity.HasIndex(e => e.Naziv)
                    .HasName("IX_Naziv");

                entity.HasIndex(e => e.SifraGrupeArtikala)
                    .HasName("IX_SifraGrupeArtikala");

                entity.HasIndex(e => e.SifraKlasifikacije)
                    .HasName("IX_SifraKlasifikacije");

                entity.HasIndex(e => e.SifraPorezneGrupe)
                    .HasName("IX_SifraPorezneGrupe");

                entity.HasIndex(e => e.SifraProizvodjaca)
                    .HasName("IX_SifraProizvodjaca");

                entity.HasIndex(e => e.ZemljaPorijekla)
                    .HasName("IX_ZemljaPorijekla");

                entity.HasIndex(e => new { e.SifraGrupeArtikala, e.SifraPodgrupeArtikala })
                    .HasName("IX_SifraGrupeArtikala_SifraPodgrupeArtikala");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BarCode)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.BarCode2).HasMaxLength(13);

                entity.Property(e => e.CarinskaTarifa)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebljinaArtikla).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Dobavljac)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.JedinicaMjere)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.KataloskiBroj)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.MaksimalnaMarzaMp)
                    .HasColumnName("MaksimalnaMarzaMP")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MaksimalnaMarzaVp)
                    .HasColumnName("MaksimalnaMarzaVP")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MaksimalnaZaliha).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinimalnaZaliha).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Opis).HasMaxLength(2000);

                entity.Property(e => e.OpisPakovanja)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PopustApsolutniIznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PosebanStatusMp).HasColumnName("PosebanStatusMP");

                entity.Property(e => e.PosebanStatusVp).HasColumnName("PosebanStatusVP");

                entity.Property(e => e.PovratPdv).HasColumnName("PovratPDV");

                entity.Property(e => e.SifraGrupeArtikala)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraKlasifikacije)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3);

                entity.Property(e => e.SifraPodgrupeArtikala).HasMaxLength(3);

                entity.Property(e => e.SifraPorezneGrupe)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraProizvodjaca)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Tezina).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VrstaArtikla)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ZaPos).HasColumnName("ZaPOS");

                entity.Property(e => e.ZemljaPorijekla)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.HasOne(d => d.DobavljacNavigation)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.Dobavljac)
                    .HasConstraintName("FK_dbo.Artikli_dbo.PoslovniPartneri_Dobavljac");

                entity.HasOne(d => d.SifraGrupeArtikalaNavigation)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.SifraGrupeArtikala)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Artikli_dbo.GrupeArtikala_SifraGrupeArtikala");

                entity.HasOne(d => d.SifraKlasifikacijeNavigation)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.SifraKlasifikacije)
                    .HasConstraintName("FK_dbo.Artikli_dbo.Klasifikacije_SifraKlasifikacije");

                entity.HasOne(d => d.SifraPorezneGrupeNavigation)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.SifraPorezneGrupe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Artikli_dbo.PorezneGrupe_SifraPorezneGrupe");

                entity.HasOne(d => d.SifraProizvodjacaNavigation)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.SifraProizvodjaca)
                    .HasConstraintName("FK_dbo.Artikli_dbo.Proizvodjaci_SifraProizvodjaca");

                entity.HasOne(d => d.ZemljaPorijeklaNavigation)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.ZemljaPorijekla)
                    .HasConstraintName("FK_dbo.Artikli_dbo.Drzave_ZemljaPorijekla");

                entity.HasOne(d => d.SifraNavigation)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => new { d.SifraGrupeArtikala, d.SifraPodgrupeArtikala })
                    .HasConstraintName("FK_dbo.Artikli_dbo.PodgrupeArtikala_SifraGrupeArtikala_SifraPodgrupeArtikala");
            });

            modelBuilder.Entity<ArtikliKalkulacijeMp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.BrojKalkulacije, e.Id })
                    .HasName("PK_dbo.ArtikliKalkulacijeMP");

                entity.ToTable("ArtikliKalkulacijeMP");

                entity.HasIndex(e => e.SifraArtikla)
                    .HasName("IX_SifraArtikla");

                entity.HasIndex(e => new { e.SifraOj, e.BrojKalkulacije })
                    .HasName("IX_SifraOJ_BrojKalkulacije");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.BrojKalkulacije)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Marza).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Rabat2).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SifraArtikla)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.ZavisniTrosak).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.SifraArtiklaNavigation)
                    .WithMany(p => p.ArtikliKalkulacijeMp)
                    .HasForeignKey(d => d.SifraArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ArtikliKalkulacijeMP_dbo.Artikli_SifraArtikla");

                entity.HasOne(d => d.KalkulacijeMp)
                    .WithMany(p => p.ArtikliKalkulacijeMp)
                    .HasForeignKey(d => new { d.SifraOj, d.BrojKalkulacije })
                    .HasConstraintName("FK_dbo.ArtikliKalkulacijeMP_dbo.KalkulacijeMP_SifraOJ_BrojKalkulacije");
            });

            modelBuilder.Entity<Banke>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Banke");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(34);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Racun)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RacunBanke).HasMaxLength(30);

                entity.Property(e => e.Swift)
                    .HasColumnName("SWIFT")
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<BankePp>(entity =>
            {
                entity.HasKey(e => new { e.SifraPp, e.SifraBanke, e.Id })
                    .HasName("PK_dbo.BankePP");

                entity.ToTable("BankePP");

                entity.HasIndex(e => e.SifraBanke)
                    .HasName("IX_SifraBanke");

                entity.HasIndex(e => e.SifraPp)
                    .HasName("IX_SifraPP");

                entity.Property(e => e.SifraPp)
                    .HasColumnName("SifraPP")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraBanke)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SifraBankeNavigation)
                    .WithMany(p => p.BankePp)
                    .HasForeignKey(d => d.SifraBanke)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.BankePP_dbo.Banke_SifraBanke");

                entity.HasOne(d => d.SifraPpNavigation)
                    .WithMany(p => p.BankePp)
                    .HasForeignKey(d => d.SifraPp)
                    .HasConstraintName("FK_dbo.BankePP_dbo.PoslovniPartneri_SifraPP");
            });

            modelBuilder.Entity<Blagajne>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Blagajne");

                entity.HasIndex(e => e.KontoPrometa)
                    .HasName("IX_KontoPrometa");

                entity.HasIndex(e => e.SifraGrupeNaloga)
                    .HasName("IX_SifraGrupeNaloga");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.SifraValute)
                    .HasName("IX_SifraValute");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Blagajnik)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KontoPrometa)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SifraGrupeNaloga)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraOj)
                    .IsRequired()
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraValute)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.KontoPrometaNavigation)
                    .WithMany(p => p.Blagajne)
                    .HasForeignKey(d => d.KontoPrometa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Blagajne_dbo.AnalitickaKonta_KontoPrometa");

                entity.HasOne(d => d.SifraGrupeNalogaNavigation)
                    .WithMany(p => p.Blagajne)
                    .HasForeignKey(d => d.SifraGrupeNaloga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Blagajne_dbo.GrupeNalogaGK_SifraGrupeNaloga");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.Blagajne)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Blagajne_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraValuteNavigation)
                    .WithMany(p => p.Blagajne)
                    .HasForeignKey(d => d.SifraValute)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Blagajne_dbo.KursnaLista_SifraValute");
            });

            modelBuilder.Entity<CashFlowItems>(entity =>
            {
                entity.HasKey(e => e.Aop)
                    .HasName("PK_dbo.CashFlowItems");

                entity.Property(e => e.Aop)
                    .HasColumnName("AOP")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.IznosProslaGodina).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Djelatnosti>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Djelatnosti");

                entity.HasIndex(e => e.Podrucje)
                    .HasName("IX_Podrucje");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Podrucje)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.PodrucjeNavigation)
                    .WithMany(p => p.Djelatnosti)
                    .HasForeignKey(d => d.Podrucje)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Djelatnosti_dbo.PodrucjeDjelatnosti_Podrucje");
            });

            modelBuilder.Entity<DodatakPdvprijave>(entity =>
            {
                entity.HasKey(e => e.Mjesec)
                    .HasName("PK_dbo.DodatakPDVPrijave");

                entity.ToTable("DodatakPDVPrijave");

                entity.HasIndex(e => e.Djelatnost)
                    .HasName("IX_Djelatnost");

                entity.Property(e => e.Mjesec)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumPdv)
                    .HasColumnName("DatumPDV")
                    .HasColumnType("datetime");

                entity.Property(e => e.Djelatnost)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.DjelatnostNavigation)
                    .WithMany(p => p.DodatakPdvprijave)
                    .HasForeignKey(d => d.Djelatnost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.DodatakPDVPrijave_dbo.Djelatnosti_Djelatnost");
            });

            modelBuilder.Entity<Dokumenti>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Dokumenti");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Strana)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DokumentiAkcijaMp>(entity =>
            {
                entity.HasKey(e => e.RedniBrojAkcije)
                    .HasName("PK_dbo.DokumentiAkcijaMP");

                entity.ToTable("DokumentiAkcijaMP");

                entity.HasIndex(e => e.SifraOrganizacioneJedinice)
                    .HasName("IX_SifraOrganizacioneJedinice");

                entity.Property(e => e.RedniBrojAkcije).HasMaxLength(6);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumVrijemePocetkaAkcije).HasColumnType("datetime");

                entity.Property(e => e.DatumVrijemeZavrsetkaAkcije).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.PopustZaSveArtikle).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SifraOrganizacioneJedinice)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraOrganizacioneJediniceNavigation)
                    .WithMany(p => p.DokumentiAkcijaMp)
                    .HasForeignKey(d => d.SifraOrganizacioneJedinice)
                    .HasConstraintName("FK_dbo.DokumentiAkcijaMP_dbo.OrganizacioneJedinice_OrganizacionaJedinica_Sifra");
            });

            modelBuilder.Entity<DokumentiPrometaMp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOrganizacioneJedinice, e.VrstaPrometa, e.BrojDokumenta })
                    .HasName("PK_dbo.DokumentiPrometaMP");

                entity.ToTable("DokumentiPrometaMP");

                entity.HasIndex(e => e.BrojRadnogNaloga)
                    .HasName("IX_BrojRadnogNaloga");

                entity.HasIndex(e => e.BrojRadnogNalogaProizvodnje)
                    .HasName("IX_BrojRadnogNalogaProizvodnje");

                entity.HasIndex(e => e.OrganizacionaJedinicaZaPrenos)
                    .HasName("IX_OrganizacionaJedinicaZaPrenos");

                entity.HasIndex(e => e.OznakaKase)
                    .HasName("IX_OznakaKase");

                entity.HasIndex(e => e.SifraOdjela)
                    .HasName("IX_SifraOdjela");

                entity.HasIndex(e => e.SifraOrganizacioneJedinice)
                    .HasName("IX_SifraOrganizacioneJedinice");

                entity.HasIndex(e => e.SifraPoslovnogPartnera)
                    .HasName("IX_SifraPoslovnogPartnera");

                entity.HasIndex(e => e.SifraPotrosaca)
                    .HasName("IX_SifraPotrosaca");

                entity.HasIndex(e => e.SifraPovremenogKupca)
                    .HasName("IX_SifraPovremenogKupca");

                entity.HasIndex(e => e.UserNameProdavaca)
                    .HasName("IX_UserNameProdavaca");

                entity.Property(e => e.SifraOrganizacioneJedinice)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaPrometa)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.BrojDokumenta)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojRadnogNaloga)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.BrojRadnogNalogaProizvodnje)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinPlacanja)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OpisDokumenta).HasMaxLength(100);

                entity.Property(e => e.OrganizacionaJedinicaZaPrenos)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OznakaKase)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraOdjela)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraPoslovnogPartnera)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraPotrosaca)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.SifraPovremenogKupca)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Smjena)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UserNameProdavaca).HasMaxLength(20);

                entity.HasOne(d => d.BrojRadnogNalogaNavigation)
                    .WithMany(p => p.DokumentiPrometaMp)
                    .HasForeignKey(d => d.BrojRadnogNaloga)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.RadniNalogMP_BrojRadnogNaloga");

                entity.HasOne(d => d.BrojRadnogNalogaProizvodnjeNavigation)
                    .WithMany(p => p.DokumentiPrometaMp)
                    .HasForeignKey(d => d.BrojRadnogNalogaProizvodnje)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.RadniNalogProizvodnje_BrojRadnogNalogaProizvodnje");

                entity.HasOne(d => d.OrganizacionaJedinicaZaPrenosNavigation)
                    .WithMany(p => p.DokumentiPrometaMpOrganizacionaJedinicaZaPrenosNavigation)
                    .HasForeignKey(d => d.OrganizacionaJedinicaZaPrenos)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.OrganizacioneJedinice_OrganizacionaJedinicaZaPrenos");

                entity.HasOne(d => d.OznakaKaseNavigation)
                    .WithMany(p => p.DokumentiPrometaMp)
                    .HasForeignKey(d => d.OznakaKase)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.Kase_OznakaKase");

                entity.HasOne(d => d.SifraOdjelaNavigation)
                    .WithMany(p => p.DokumentiPrometaMp)
                    .HasForeignKey(d => d.SifraOdjela)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.Odjeli_SifraOdjela");

                entity.HasOne(d => d.SifraOrganizacioneJediniceNavigation)
                    .WithMany(p => p.DokumentiPrometaMpSifraOrganizacioneJediniceNavigation)
                    .HasForeignKey(d => d.SifraOrganizacioneJedinice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.OrganizacioneJedinice_SifraOrganizacioneJedinice");

                entity.HasOne(d => d.SifraPoslovnogPartneraNavigation)
                    .WithMany(p => p.DokumentiPrometaMp)
                    .HasForeignKey(d => d.SifraPoslovnogPartnera)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.PoslovniPartneri_SifraPoslovnogPartnera");

                entity.HasOne(d => d.SifraPotrosacaNavigation)
                    .WithMany(p => p.DokumentiPrometaMp)
                    .HasForeignKey(d => d.SifraPotrosaca)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.Potrosaci_SifraPotrosaca");

                entity.HasOne(d => d.SifraPovremenogKupcaNavigation)
                    .WithMany(p => p.DokumentiPrometaMp)
                    .HasForeignKey(d => d.SifraPovremenogKupca)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.PovremeniKupci_SifraPovremenogKupca");

                entity.HasOne(d => d.UserNameProdavacaNavigation)
                    .WithMany(p => p.DokumentiPrometaMp)
                    .HasForeignKey(d => d.UserNameProdavaca)
                    .HasConstraintName("FK_dbo.DokumentiPrometaMP_dbo.Prodavaci_UserNameProdavaca");
            });

            modelBuilder.Entity<DokumentiPrometaRepromaterijala>(entity =>
            {
                entity.HasKey(e => new { e.SkladisteId, e.VrstaPrometaId, e.BrojDokumenta })
                    .HasName("PK_dbo.DokumentiPrometaRepromaterijala");

                entity.HasIndex(e => e.BrojRadnogNaloga)
                    .HasName("IX_BrojRadnogNaloga");

                entity.HasIndex(e => e.OrganizacionaJedinicaId)
                    .HasName("IX_OrganizacionaJedinicaId");

                entity.HasIndex(e => e.PoslovniPartnerId)
                    .HasName("IX_PoslovniPartnerId");

                entity.HasIndex(e => e.SkladisteId)
                    .HasName("IX_SkladisteId");

                entity.Property(e => e.SkladisteId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaPrometaId)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.BrojDokumenta)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojRadnogNaloga)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisDokumenta).HasMaxLength(100);

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PoslovniPartnerId)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.HasOne(d => d.BrojRadnogNalogaNavigation)
                    .WithMany(p => p.DokumentiPrometaRepromaterijala)
                    .HasForeignKey(d => d.BrojRadnogNaloga)
                    .HasConstraintName("FK_dbo.DokumentiPrometaRepromaterijala_dbo.RadniNalogProizvodnje_BrojRadnogNaloga");

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.DokumentiPrometaRepromaterijalaOrganizacionaJedinica)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .HasConstraintName("FK_dbo.DokumentiPrometaRepromaterijala_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");

                entity.HasOne(d => d.PoslovniPartner)
                    .WithMany(p => p.DokumentiPrometaRepromaterijala)
                    .HasForeignKey(d => d.PoslovniPartnerId)
                    .HasConstraintName("FK_dbo.DokumentiPrometaRepromaterijala_dbo.PoslovniPartneri_PoslovniPartnerId");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.DokumentiPrometaRepromaterijalaSkladiste)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.DokumentiPrometaRepromaterijala_dbo.OrganizacioneJedinice_SkladisteId");
            });

            modelBuilder.Entity<DokumentiPrometaVp>(entity =>
            {
                entity.HasKey(e => new { e.SkladisteId, e.VrstaPrometaId, e.BrojDokumenta })
                    .HasName("PK_dbo.DokumentiPrometaVP");

                entity.ToTable("DokumentiPrometaVP");

                entity.HasIndex(e => e.BrojOtpremniceVeleprodajeUtoku)
                    .HasName("IX_BrojOtpremniceVeleprodajeUToku");

                entity.HasIndex(e => e.BrojRadnogNalogaProizvodnje)
                    .HasName("IX_BrojRadnogNalogaProizvodnje");

                entity.HasIndex(e => e.OrganizacionaJedinicaId)
                    .HasName("IX_OrganizacionaJedinicaId");

                entity.HasIndex(e => e.SkladisteId)
                    .HasName("IX_SkladisteId");

                entity.HasIndex(e => new { e.SifraPoslovneJedinice, e.PoslovniPartnerId })
                    .HasName("IX_SifraPoslovneJedinice_PoslovniPartnerId");

                entity.Property(e => e.SkladisteId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaPrometaId)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.BrojDokumenta)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojOtpremniceVeleprodajeUtoku)
                    .HasColumnName("BrojOtpremniceVeleprodajeUToku")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.BrojRadnogNalogaProizvodnje)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisDokumenta).HasMaxLength(100);

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PoslovniPartnerId)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraPoslovneJedinice)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.BrojOtpremniceVeleprodajeUtokuNavigation)
                    .WithMany(p => p.DokumentiPrometaVp)
                    .HasForeignKey(d => d.BrojOtpremniceVeleprodajeUtoku)
                    .HasConstraintName("FK_dbo.DokumentiPrometaVP_dbo.OtpremniceVeleprodajeUToku_BrojOtpremniceVeleprodajeUToku");

                entity.HasOne(d => d.BrojRadnogNalogaProizvodnjeNavigation)
                    .WithMany(p => p.DokumentiPrometaVp)
                    .HasForeignKey(d => d.BrojRadnogNalogaProizvodnje)
                    .HasConstraintName("FK_dbo.DokumentiPrometaVP_dbo.RadniNalogProizvodnje_BrojRadnogNalogaProizvodnje");

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.DokumentiPrometaVpOrganizacionaJedinica)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .HasConstraintName("FK_dbo.DokumentiPrometaVP_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");

                entity.HasOne(d => d.PoslovniPartner)
                    .WithMany(p => p.DokumentiPrometaVp)
                    .HasForeignKey(d => d.PoslovniPartnerId)
                    .HasConstraintName("FK_dbo.DokumentiPrometaVP_dbo.PoslovniPartneri_PoslovniPartnerId");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.DokumentiPrometaVpSkladiste)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.DokumentiPrometaVP_dbo.OrganizacioneJedinice_SkladisteId");

                entity.HasOne(d => d.PoslovneJedinice)
                    .WithMany(p => p.DokumentiPrometaVp)
                    .HasForeignKey(d => new { d.SifraPoslovneJedinice, d.PoslovniPartnerId })
                    .HasConstraintName("FK_dbo.DokumentiPrometaVP_dbo.PoslovneJedinice_SifraPoslovneJedinice_PoslovniPartnerId");
            });

            modelBuilder.Entity<Drzave>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Drzave");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NazivDrzave)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumerickaOznaka)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OznakaDrzave)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Firma>(entity =>
            {
                entity.HasIndex(e => e.DjelatnostId)
                    .HasName("IX_DjelatnostId");

                entity.HasIndex(e => e.OblikOrganizacije)
                    .HasName("IX_OblikOrganizacije");

                entity.HasIndex(e => e.PttBroj)
                    .HasName("IX_PttBroj");

                entity.HasIndex(e => e.SifraOpcine)
                    .HasName("IX_SifraOpcine");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.AdresaZastupnika).HasMaxLength(50);

                entity.Property(e => e.BrojDozvoleRac).HasMaxLength(10);

                entity.Property(e => e.BrojUlice)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DatumUpisa).HasColumnType("datetime");

                entity.Property(e => e.DjelatnostId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.IdbrojRac)
                    .HasColumnName("IDBrojRac")
                    .HasMaxLength(13);

                entity.Property(e => e.ImeIprezimeRac)
                    .HasColumnName("ImeIPrezimeRac")
                    .HasMaxLength(50);

                entity.Property(e => e.ImeIprezimeZastupnika)
                    .HasColumnName("ImeIPrezimeZastupnika")
                    .HasMaxLength(50);

                entity.Property(e => e.Jmbgol)
                    .HasColumnName("JMBGOL")
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Mobitel).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NazivExt).HasMaxLength(100);

                entity.Property(e => e.OblikOrganizacije)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OdgovornoLice).HasMaxLength(50);

                entity.Property(e => e.OznakaValute)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PdvBroj)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.PorezniBroj)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.PttBroj)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.RegBrojUpisa).HasMaxLength(20);

                entity.Property(e => e.SifraOpcine)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraUposlovnimPartnerima)
                    .HasColumnName("SifraUPoslovnimPartnerima")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraZaGotovinskuProdaju)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraZaVanposlovneSvrhe)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Sud).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.Property(e => e.TelefonRac).HasMaxLength(50);

                entity.Property(e => e.Ulica)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Web).HasMaxLength(50);

                entity.HasOne(d => d.Djelatnost)
                    .WithMany(p => p.Firma)
                    .HasForeignKey(d => d.DjelatnostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Firma_dbo.Djelatnosti_DjelatnostId");

                entity.HasOne(d => d.OblikOrganizacijeNavigation)
                    .WithMany(p => p.Firma)
                    .HasForeignKey(d => d.OblikOrganizacije)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Firma_dbo.OblikOrganizovanja_OblikOrganizacije");

                entity.HasOne(d => d.PttBrojNavigation)
                    .WithMany(p => p.Firma)
                    .HasForeignKey(d => d.PttBroj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Firma_dbo.Mjesta_PttBroj");

                entity.HasOne(d => d.SifraOpcineNavigation)
                    .WithMany(p => p.Firma)
                    .HasForeignKey(d => d.SifraOpcine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Firma_dbo.Opcine_SifraOpcine");
            });

            modelBuilder.Entity<FiskalniPisaci>(entity =>
            {
                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BackUpFolder)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CommandFile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandFolder)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ErrorFolder)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ibfu)
                    .IsRequired()
                    .HasColumnName("IBFU")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Iosa)
                    .IsRequired()
                    .HasColumnName("IOSA")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.LocalClientBase)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LocalItemsBase)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LozinkaProdavaca)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PohranaArtikalaUpisac)
                    .IsRequired()
                    .HasColumnName("PohranaArtikalaUPisac")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Prodavac)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ResponseFile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResponseFolder)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SerijskiBroj)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.ServerHost)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Text1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Text2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Workstation)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GotoviProizvodiRadnogNalogaProizvodnje>(entity =>
            {
                entity.HasKey(e => new { e.BrojRadnogNaloga, e.SifraGotovogProizvoda, e.Id })
                    .HasName("PK_dbo.GotoviProizvodiRadnogNalogaProizvodnje");

                entity.HasIndex(e => e.BrojRadnogNaloga)
                    .HasName("IX_BrojRadnogNaloga");

                entity.HasIndex(e => e.SifraGotovogProizvoda)
                    .HasName("IX_SifraGotovogProizvoda");

                entity.Property(e => e.BrojRadnogNaloga)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.SifraGotovogProizvoda)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Boja)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinObracunaPdv)
                    .HasColumnName("NacinObracunaPDV")
                    .HasMaxLength(1);

                entity.Property(e => e.NacinPakovanja)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Opis).IsRequired();

                entity.Property(e => e.ProdajnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ProizvodnaCijena).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.BrojRadnogNalogaNavigation)
                    .WithMany(p => p.GotoviProizvodiRadnogNalogaProizvodnje)
                    .HasForeignKey(d => d.BrojRadnogNaloga)
                    .HasConstraintName("FK_dbo.GotoviProizvodiRadnogNalogaProizvodnje_dbo.RadniNalogProizvodnje_BrojRadnogNaloga");

                entity.HasOne(d => d.SifraGotovogProizvodaNavigation)
                    .WithMany(p => p.GotoviProizvodiRadnogNalogaProizvodnje)
                    .HasForeignKey(d => d.SifraGotovogProizvoda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GotoviProizvodiRadnogNalogaProizvodnje_dbo.Artikli_SifraGotovogProizvoda");
            });

            modelBuilder.Entity<GrupaPripremljenihRacuna>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.GrupaPripremljenihRacuna");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PeriodFakturisanja)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GrupeArtikala>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.GrupeArtikala");

                entity.HasIndex(e => e.KontoPrihoda)
                    .HasName("IX_KontoPrihoda");

                entity.HasIndex(e => e.KontoPrihodaInostranoTrziste)
                    .HasName("IX_KontoPrihodaInostranoTrziste");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.KontoPrihoda)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoPrihodaInostranoTrziste)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.KontoPrihodaNavigation)
                    .WithMany(p => p.GrupeArtikalaKontoPrihodaNavigation)
                    .HasForeignKey(d => d.KontoPrihoda)
                    .HasConstraintName("FK_dbo.GrupeArtikala_dbo.AnalitickaKonta_KontoPrihoda");

                entity.HasOne(d => d.KontoPrihodaInostranoTrzisteNavigation)
                    .WithMany(p => p.GrupeArtikalaKontoPrihodaInostranoTrzisteNavigation)
                    .HasForeignKey(d => d.KontoPrihodaInostranoTrziste)
                    .HasConstraintName("FK_dbo.GrupeArtikala_dbo.AnalitickaKonta_KontoPrihodaInostranoTrziste");
            });

            modelBuilder.Entity<GrupeKonta>(entity =>
            {
                entity.HasKey(e => e.Broj)
                    .HasName("PK_dbo.GrupeKonta");

                entity.Property(e => e.Broj)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OcekivaniSaldo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GrupeNalogaGk>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.GrupeNalogaGK");

                entity.ToTable("GrupeNalogaGK");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VezaSaKifKuf)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('2')");
            });

            modelBuilder.Entity<GrupeUsluga>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.GrupeUsluga");

                entity.HasIndex(e => e.KontoPrihoda)
                    .HasName("IX_KontoPrihoda");

                entity.HasIndex(e => e.KontoPrihodaInostranoTrziste)
                    .HasName("IX_KontoPrihodaInostranoTrziste");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.KontoPrihoda)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoPrihodaInostranoTrziste)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis).HasMaxLength(50);

                entity.HasOne(d => d.KontoPrihodaNavigation)
                    .WithMany(p => p.GrupeUslugaKontoPrihodaNavigation)
                    .HasForeignKey(d => d.KontoPrihoda)
                    .HasConstraintName("FK_dbo.GrupeUsluga_dbo.AnalitickaKonta_KontoPrihoda");

                entity.HasOne(d => d.KontoPrihodaInostranoTrzisteNavigation)
                    .WithMany(p => p.GrupeUslugaKontoPrihodaInostranoTrzisteNavigation)
                    .HasForeignKey(d => d.KontoPrihodaInostranoTrziste)
                    .HasConstraintName("FK_dbo.GrupeUsluga_dbo.AnalitickaKonta_KontoPrihodaInostranoTrziste");
            });

            modelBuilder.Entity<IznosiZaObracunUcinkaKomercijaliste>(entity =>
            {
                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Do).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Od).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Postotak).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<KalkulacijeMp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.BrojKalkulacije })
                    .HasName("PK_dbo.KalkulacijeMP");

                entity.ToTable("KalkulacijeMP");

                entity.HasIndex(e => e.SifraDobavljaca)
                    .HasName("IX_SifraDobavljaca");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.SifraOjdonosa)
                    .HasName("IX_SifraOJDonosa");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.BrojKalkulacije)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DatumKalkulacije).HasColumnType("datetime");

                entity.Property(e => e.DatumRacuna).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisKalkulacije)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SifraDobavljaca)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraOjdonosa)
                    .HasColumnName("SifraOJDonosa")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.UlazniPdv)
                    .HasColumnName("UlazniPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.SifraDobavljacaNavigation)
                    .WithMany(p => p.KalkulacijeMp)
                    .HasForeignKey(d => d.SifraDobavljaca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeMP_dbo.PoslovniPartneri_SifraDobavljaca");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.KalkulacijeMpSifraOjNavigation)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeMP_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraOjdonosaNavigation)
                    .WithMany(p => p.KalkulacijeMpSifraOjdonosaNavigation)
                    .HasForeignKey(d => d.SifraOjdonosa)
                    .HasConstraintName("FK_dbo.KalkulacijeMP_dbo.OrganizacioneJedinice_SifraOJDonosa");
            });

            modelBuilder.Entity<KalkulacijeRepromaterijala>(entity =>
            {
                entity.HasKey(e => new { e.SkladisteId, e.BrojKalkulacije })
                    .HasName("PK_dbo.KalkulacijeRepromaterijala");

                entity.HasIndex(e => e.DobavljacId)
                    .HasName("IX_DobavljacId");

                entity.HasIndex(e => e.SkladisteId)
                    .HasName("IX_SkladisteId");

                entity.Property(e => e.SkladisteId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.BrojKalkulacije)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DatumKalkulacije).HasColumnType("datetime");

                entity.Property(e => e.DatumRacuna).HasColumnType("datetime");

                entity.Property(e => e.DobavljacId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisKalkulacije)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UlazniPdv)
                    .HasColumnName("UlazniPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Dobavljac)
                    .WithMany(p => p.KalkulacijeRepromaterijala)
                    .HasForeignKey(d => d.DobavljacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeRepromaterijala_dbo.PoslovniPartneri_DobavljacId");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.KalkulacijeRepromaterijala)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeRepromaterijala_dbo.OrganizacioneJedinice_SkladisteId");
            });

            modelBuilder.Entity<KalkulacijeRepromaterijalaZavisniTroskovi>(entity =>
            {
                entity.HasKey(e => new { e.SkladisteId, e.BrojKalkulacije, e.RepromaterijalId, e.Id })
                    .HasName("PK_dbo.KalkulacijeRepromaterijalaZavisniTroskovi");

                entity.HasIndex(e => e.RepromaterijalId)
                    .HasName("IX_RepromaterijalId");

                entity.HasIndex(e => e.SifraZavisnogTroska)
                    .HasName("IX_SifraZavisnogTroska");

                entity.HasIndex(e => new { e.SkladisteId, e.BrojKalkulacije, e.KalkulacijaItemId })
                    .HasName("IX_SkladisteId_BrojKalkulacije_KalkulacijaItemId");

                entity.Property(e => e.SkladisteId)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BrojKalkulacije)
                    .HasMaxLength(6)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RepromaterijalId)
                    .HasMaxLength(6)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IznosZavisnogTroska).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcenatZavisnogTroska).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SifraZavisnogTroska)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.Repromaterijal)
                    .WithMany(p => p.KalkulacijeRepromaterijalaZavisniTroskovi)
                    .HasForeignKey(d => d.RepromaterijalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeRepromaterijalaZavisniTroskovi_dbo.Repromaterijal_RepromaterijalId");

                entity.HasOne(d => d.SifraZavisnogTroskaNavigation)
                    .WithMany(p => p.KalkulacijeRepromaterijalaZavisniTroskovi)
                    .HasForeignKey(d => d.SifraZavisnogTroska)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeRepromaterijalaZavisniTroskovi_dbo.ZavisniTroskovi_SifraZavisnogTroska");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.KalkulacijeRepromaterijalaZavisniTroskovi)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeRepromaterijalaZavisniTroskovi_dbo.OrganizacioneJedinice_SkladisteId");

                entity.HasOne(d => d.StavkeKalkulacijeRepromaterijala)
                    .WithMany(p => p.KalkulacijeRepromaterijalaZavisniTroskovi)
                    .HasForeignKey(d => new { d.SkladisteId, d.BrojKalkulacije, d.KalkulacijaItemId })
                    .HasConstraintName("FK_dbo.KalkulacijeRepromaterijalaZavisniTroskovi_dbo.StavkeKalkulacijeRepromaterijala_SkladisteId_BrojKalkulacije_KalkulacijaIte");
            });

            modelBuilder.Entity<KalkulacijeVp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.BrojKalkulacije })
                    .HasName("PK_dbo.KalkulacijeVP");

                entity.ToTable("KalkulacijeVP");

                entity.HasIndex(e => e.SifraDobavljaca)
                    .HasName("IX_SifraDobavljaca");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.SifraOjdonosa)
                    .HasName("IX_SifraOJDonosa");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.BrojKalkulacije)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DatumKalkulacije).HasColumnType("datetime");

                entity.Property(e => e.DatumRacuna).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisKalkulacije)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SifraDobavljaca)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraOjdonosa)
                    .HasColumnName("SifraOJDonosa")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.UlazniPdv)
                    .HasColumnName("UlazniPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.SifraDobavljacaNavigation)
                    .WithMany(p => p.KalkulacijeVp)
                    .HasForeignKey(d => d.SifraDobavljaca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeVP_dbo.PoslovniPartneri_SifraDobavljaca");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.KalkulacijeVpSifraOjNavigation)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeVP_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraOjdonosaNavigation)
                    .WithMany(p => p.KalkulacijeVpSifraOjdonosaNavigation)
                    .HasForeignKey(d => d.SifraOjdonosa)
                    .HasConstraintName("FK_dbo.KalkulacijeVP_dbo.OrganizacioneJedinice_SifraOJDonosa");
            });

            modelBuilder.Entity<KalkulacijeZavisniTroskovi>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.BrojKalkulacije, e.SifraArtikla, e.Id })
                    .HasName("PK_dbo.KalkulacijeZavisniTroskovi");

                entity.HasIndex(e => e.SifraArtikla)
                    .HasName("IX_SifraArtikla");

                entity.HasIndex(e => e.SifraZavisnogTroska)
                    .HasName("IX_SifraZavisnogTroska");

                entity.HasIndex(e => new { e.SifraOj, e.BrojKalkulacije, e.KalkulacijaItemId })
                    .HasName("IX_SifraOJ_BrojKalkulacije_KalkulacijaItemId");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BrojKalkulacije)
                    .HasMaxLength(6)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SifraArtikla)
                    .HasMaxLength(6)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IznosZavisnogTroska).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcenatZavisnogTroska).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SifraZavisnogTroska)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraArtiklaNavigation)
                    .WithMany(p => p.KalkulacijeZavisniTroskovi)
                    .HasForeignKey(d => d.SifraArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeZavisniTroskovi_dbo.Artikli_SifraArtikla");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.KalkulacijeZavisniTroskovi)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeZavisniTroskovi_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraZavisnogTroskaNavigation)
                    .WithMany(p => p.KalkulacijeZavisniTroskovi)
                    .HasForeignKey(d => d.SifraZavisnogTroska)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KalkulacijeZavisniTroskovi_dbo.ZavisniTroskovi_SifraZavisnogTroska");

                entity.HasOne(d => d.StavkeKalkulacijeVp)
                    .WithMany(p => p.KalkulacijeZavisniTroskovi)
                    .HasForeignKey(d => new { d.SifraOj, d.BrojKalkulacije, d.KalkulacijaItemId })
                    .HasConstraintName("FK_dbo.KalkulacijeZavisniTroskovi_dbo.StavkeKalkulacijeVP_SifraOJ_BrojKalkulacije_KalkulacijaItemId");
            });

            modelBuilder.Entity<KamatniKalkulator>(entity =>
            {
                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DoDatuma).HasColumnType("datetime");

                entity.Property(e => e.GodisnjaStopa).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.IznosZaObracun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MetodaObracuna)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OdDatuma).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Kantoni>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Kantoni");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SkraceniNaziv)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Kase>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Kase");

                entity.HasIndex(e => e.SifraOrganizacioneJedinice)
                    .HasName("IX_SifraOrganizacioneJedinice");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SifraOrganizacioneJedinice)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraSmjene).HasMaxLength(1);

                entity.HasOne(d => d.SifraOrganizacioneJediniceNavigation)
                    .WithMany(p => p.Kase)
                    .HasForeignKey(d => d.SifraOrganizacioneJedinice)
                    .HasConstraintName("FK_dbo.Kase_dbo.OrganizacioneJedinice_SifraOrganizacioneJedinice");
            });

            modelBuilder.Entity<KategorijePrometaDobavljaca>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.KategorijePrometaDobavljaca");

                entity.HasIndex(e => e.Konto)
                    .HasName("IX_Konto");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Konto)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.KontoNavigation)
                    .WithMany(p => p.KategorijePrometaDobavljaca)
                    .HasForeignKey(d => d.Konto)
                    .HasConstraintName("FK_dbo.KategorijePrometaDobavljaca_dbo.AnalitickaKonta_Konto");
            });

            modelBuilder.Entity<Kif>(entity =>
            {
                entity.HasKey(e => e.RedniBroj)
                    .HasName("PK_dbo.Kif");

                entity.HasIndex(e => e.SifraKupca)
                    .HasName("IX_SifraKupca");

                entity.Property(e => e.RedniBroj)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojFakture)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BrojJci)
                    .HasColumnName("BrojJCI")
                    .HasMaxLength(50);

                entity.Property(e => e.DatumFakture).HasColumnType("datetime");

                entity.Property(e => e.DatumJci)
                    .HasColumnName("DatumJCI")
                    .HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IznosFaktureBezPdva)
                    .HasColumnName("IznosFaktureBezPDVa")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosFaktureIzvoz).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosInterneFakture).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MjesecObrade)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.MjestoKrajnjePotrosnje)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("('F')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis).HasMaxLength(300);

                entity.Property(e => e.OsnovicaZaPdv)
                    .HasColumnName("OsnovicaZaPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SifraKupca)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.TipDokumenta)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.UkupniIznosFakture).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UkupniIznosPdva)
                    .HasColumnName("UkupniIznosPDVa")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VrstaDokumenta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.VrstaFakture)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraKupcaNavigation)
                    .WithMany(p => p.Kif)
                    .HasForeignKey(d => d.SifraKupca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Kif_dbo.PoslovniPartneri_SifraKupca");
            });

            modelBuilder.Entity<KlaseKonta>(entity =>
            {
                entity.HasKey(e => e.Broj)
                    .HasName("PK_dbo.KlaseKonta");

                entity.Property(e => e.Broj)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Vrsta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Klasifikacije>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Klasifikacije");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<KnjizneObavijesti>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.VrstaKnjizneObavijesti, e.BrojKnjizneObavijesti })
                    .HasName("PK_dbo.KnjizneObavijesti");

                entity.HasIndex(e => e.PoslovniPartnerId)
                    .HasName("IX_PoslovniPartnerId");

                entity.HasIndex(e => e.SifraKomercijaliste)
                    .HasName("IX_SifraKomercijaliste");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.SifraTeksta)
                    .HasName("IX_SifraTeksta");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaKnjizneObavijesti)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.BrojKnjizneObavijesti)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojOtpremnice).HasMaxLength(50);

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.DatumDpo)
                    .HasColumnName("DatumDPO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatumOtpremnice).HasColumnType("datetime");

                entity.Property(e => e.DatumRacuna).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisRacuna).HasMaxLength(500);

                entity.Property(e => e.OriginalniDokument).HasMaxLength(50);

                entity.Property(e => e.PoslovniPartnerId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraKomercijaliste)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraTeksta)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.PoslovniPartner)
                    .WithMany(p => p.KnjizneObavijesti)
                    .HasForeignKey(d => d.PoslovniPartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KnjizneObavijesti_dbo.PoslovniPartneri_PoslovniPartnerId");

                entity.HasOne(d => d.SifraKomercijalisteNavigation)
                    .WithMany(p => p.KnjizneObavijesti)
                    .HasForeignKey(d => d.SifraKomercijaliste)
                    .HasConstraintName("FK_dbo.KnjizneObavijesti_dbo.Komercijalisti_SifraKomercijaliste");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.KnjizneObavijesti)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KnjizneObavijesti_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraTekstaNavigation)
                    .WithMany(p => p.KnjizneObavijesti)
                    .HasForeignKey(d => d.SifraTeksta)
                    .HasConstraintName("FK_dbo.KnjizneObavijesti_dbo.Tekstovi_SifraTeksta");
            });

            modelBuilder.Entity<Komercijalisti>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Komercijalisti");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ImePrezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Napomena).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PostotakKorekcije).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.UserName).HasMaxLength(20);

                entity.Property(e => e.Vrsta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<KontoZaPrelazUprometPps>(entity =>
            {
                entity.HasKey(e => e.Konto)
                    .HasName("PK_dbo.KontoZaPrelazUPrometPPs");

                entity.ToTable("KontoZaPrelazUPrometPPs");

                entity.Property(e => e.Konto)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Strana).HasMaxLength(1);

                entity.Property(e => e.VrstaPrometa).HasMaxLength(1);
            });

            modelBuilder.Entity<Korespondencija>(entity =>
            {
                entity.HasKey(e => new { e.SifraPoslovnogPartnera, e.Id })
                    .HasName("PK_dbo.Korespondencija");

                entity.HasIndex(e => e.SifraPoslovnogPartnera)
                    .HasName("IX_SifraPoslovnogPartnera");

                entity.Property(e => e.SifraPoslovnogPartnera)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.DogovoreniDatum).HasColumnType("datetime");

                entity.Property(e => e.KontaktOsoba)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis).IsRequired();

                entity.HasOne(d => d.SifraPoslovnogPartneraNavigation)
                    .WithMany(p => p.Korespondencija)
                    .HasForeignKey(d => d.SifraPoslovnogPartnera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Korespondencija_dbo.PoslovniPartneri_SifraPoslovnogPartnera");
            });

            modelBuilder.Entity<Kuf>(entity =>
            {
                entity.HasKey(e => e.RedniBroj)
                    .HasName("PK_dbo.Kuf");

                entity.HasIndex(e => e.SifraDobavljaca)
                    .HasName("IX_SifraDobavljaca");

                entity.Property(e => e.RedniBroj)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojFakture)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BrojJci)
                    .HasColumnName("BrojJCI")
                    .HasMaxLength(50);

                entity.Property(e => e.DatumFakture).HasColumnType("datetime");

                entity.Property(e => e.DatumJci)
                    .HasColumnName("DatumJCI")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatumPrijema).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IznosBezPdv)
                    .HasColumnName("IznosBezPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosPdv)
                    .HasColumnName("IznosPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MjesecObrade)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.MjestoKrajnjePotrosnje)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("('F')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NepriznatiPdv)
                    .HasColumnName("NepriznatiPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Opis).HasMaxLength(300);

                entity.Property(e => e.PausalnaNaknada).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriznatiPdv)
                    .HasColumnName("PriznatiPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SifraDobavljaca)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.TipDokumenta)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.UkupniIznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VrstaDokumenta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VrstaFakture)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraDobavljacaNavigation)
                    .WithMany(p => p.Kuf)
                    .HasForeignKey(d => d.SifraDobavljaca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Kuf_dbo.PoslovniPartneri_SifraDobavljaca");
            });

            modelBuilder.Entity<KufUvoz>(entity =>
            {
                entity.HasKey(e => new { e.RedniBrojKuf, e.RedniBroj })
                    .HasName("PK_dbo.KufUvoz");

                entity.HasIndex(e => e.RedniBrojKuf)
                    .HasName("IX_RedniBrojKuf");

                entity.HasIndex(e => e.SifraDobavljaca)
                    .HasName("IX_SifraDobavljaca");

                entity.Property(e => e.RedniBrojKuf)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.RedniBroj)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojFakture)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BrojJci)
                    .HasColumnName("BrojJCI")
                    .HasMaxLength(50);

                entity.Property(e => e.DatumFakture).HasColumnType("datetime");

                entity.Property(e => e.DatumJci)
                    .HasColumnName("DatumJCI")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatumPrijema).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IznosBezPdv)
                    .HasColumnName("IznosBezPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosPdv)
                    .HasColumnName("IznosPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MjesecObrade)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.MjestoKrajnjePotrosnje)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NepriznatiPdv)
                    .HasColumnName("NepriznatiPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Opis).HasMaxLength(300);

                entity.Property(e => e.PausalnaNaknada).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriznatiPdv)
                    .HasColumnName("PriznatiPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SifraDobavljaca)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.TipDokumenta)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.UkupniIznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VrstaDokumenta)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.VrstaFakture)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.HasOne(d => d.RedniBrojKufNavigation)
                    .WithMany(p => p.KufUvoz)
                    .HasForeignKey(d => d.RedniBrojKuf)
                    .HasConstraintName("FK_dbo.KufUvoz_dbo.Kuf_RedniBrojKuf");

                entity.HasOne(d => d.SifraDobavljacaNavigation)
                    .WithMany(p => p.KufUvoz)
                    .HasForeignKey(d => d.SifraDobavljaca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KufUvoz_dbo.PoslovniPartneri_SifraDobavljaca");
            });

            modelBuilder.Entity<KursnaLista>(entity =>
            {
                entity.HasKey(e => e.SifraValute)
                    .HasName("PK_dbo.KursnaLista");

                entity.Property(e => e.SifraValute)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.KupovniKurs).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OznakaValute)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ProdajniKurs).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SrednjiKurs).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Zemlja)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Mjesta>(entity =>
            {
                entity.HasKey(e => e.PttBroj)
                    .HasName("PK_dbo.Mjesta");

                entity.Property(e => e.PttBroj)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MobileOrderItems>(entity =>
            {
                entity.HasIndex(e => e.MobileOrderId)
                    .HasName("IX_MobileOrderId");

                entity.HasIndex(e => e.SifraArtikla)
                    .HasName("IX_SifraArtikla");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KolicinaNaTalonu).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SifraArtikla)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.SifraGrupeArtikala)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.HasOne(d => d.MobileOrder)
                    .WithMany(p => p.MobileOrderItems)
                    .HasForeignKey(d => d.MobileOrderId)
                    .HasConstraintName("FK_dbo.MobileOrderItems_dbo.MobileOrders_MobileOrderId");

                entity.HasOne(d => d.SifraArtiklaNavigation)
                    .WithMany(p => p.MobileOrderItems)
                    .HasForeignKey(d => d.SifraArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MobileOrderItems_dbo.Artikli_SifraArtikla");
            });

            modelBuilder.Entity<MobileOrders>(entity =>
            {
                entity.HasIndex(e => e.UserNameProdavaca)
                    .HasName("IX_UserNameProdavaca");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumIvrijeme)
                    .HasColumnName("DatumIVrijeme")
                    .HasColumnType("datetime");

                entity.Property(e => e.DodatniOpis).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserNameProdavaca).HasMaxLength(20);

                entity.HasOne(d => d.UserNameProdavacaNavigation)
                    .WithMany(p => p.MobileOrders)
                    .HasForeignKey(d => d.UserNameProdavaca)
                    .HasConstraintName("FK_dbo.MobileOrders_dbo.Prodavaci_UserNameProdavaca");
            });

            modelBuilder.Entity<NaljepnicaUroli>(entity =>
            {
                entity.ToTable("NaljepnicaURoli");

                entity.Property(e => e.NaljepnicaUroliId)
                    .HasColumnName("NaljepnicaURoliId")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.IpadresaPisaca)
                    .HasColumnName("IPAdresaPisaca")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.ParalelPortName).HasMaxLength(10);

                entity.Property(e => e.PrinterName).HasMaxLength(200);

                entity.Property(e => e.SerialPortName).HasMaxLength(10);
            });

            modelBuilder.Entity<NaloziBlagajne>(entity =>
            {
                entity.HasKey(e => new { e.BlagajnaId, e.Broj })
                    .HasName("PK_dbo.NaloziBlagajne");

                entity.HasIndex(e => e.BlagajnaId)
                    .HasName("IX_BlagajnaId");

                entity.Property(e => e.BlagajnaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Broj)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Kurs).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisDokumenta)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Blagajna)
                    .WithMany(p => p.NaloziBlagajne)
                    .HasForeignKey(d => d.BlagajnaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.NaloziBlagajne_dbo.Blagajne_BlagajnaId");
            });

            modelBuilder.Entity<NaloziDobavljaca>(entity =>
            {
                entity.HasKey(e => e.Broj)
                    .HasName("PK_dbo.NaloziDobavljaca");

                entity.Property(e => e.Broj)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NaloziGk>(entity =>
            {
                entity.HasKey(e => e.Broj)
                    .HasName("PK_dbo.NaloziGK");

                entity.ToTable("NaloziGK");

                entity.Property(e => e.Broj)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NaloziKompenzacije>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.Sifra })
                    .HasName("PK_dbo.NaloziKompenzacije");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.SifraPp)
                    .HasName("IX_SifraPP");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sifra).HasMaxLength(6);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SifraPp)
                    .IsRequired()
                    .HasColumnName("SifraPP")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.UtvrdjenoNaDan).HasColumnType("datetime");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.NaloziKompenzacije)
                    .HasForeignKey(d => d.SifraOj)
                    .HasConstraintName("FK_dbo.NaloziKompenzacije_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraPpNavigation)
                    .WithMany(p => p.NaloziKompenzacije)
                    .HasForeignKey(d => d.SifraPp)
                    .HasConstraintName("FK_dbo.NaloziKompenzacije_dbo.PoslovniPartneri_SifraPP");
            });

            modelBuilder.Entity<NaloziKupca>(entity =>
            {
                entity.HasKey(e => e.Broj)
                    .HasName("PK_dbo.NaloziKupca");

                entity.Property(e => e.Broj)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NaloziZaPlacanje>(entity =>
            {
                entity.HasKey(e => e.NalogZaPlacanjeId)
                    .HasName("PK_dbo.NaloziZaPlacanje");

                entity.Property(e => e.NalogZaPlacanjeId)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojPoreznogObveznika).HasMaxLength(15);

                entity.Property(e => e.BudzetskaOrganizacija).HasMaxLength(10);

                entity.Property(e => e.DatumUplate).HasColumnType("datetime");

                entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KrajnjiDatumPoreznogPerioda).HasColumnType("datetime");

                entity.Property(e => e.MjestoUplate).HasMaxLength(25);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opcina)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Opis).HasMaxLength(100);

                entity.Property(e => e.PocetniDatumPoreznogPerioda).HasColumnType("datetime");

                entity.Property(e => e.PozivNaBroj).HasMaxLength(12);

                entity.Property(e => e.PrimalacDrugiRed).HasMaxLength(25);

                entity.Property(e => e.PrimalacPrviRed).HasMaxLength(15);

                entity.Property(e => e.PrimalacTreciRed).HasMaxLength(25);

                entity.Property(e => e.RacunPrimaoca).HasMaxLength(30);

                entity.Property(e => e.RacunUplatioca).HasMaxLength(30);

                entity.Property(e => e.SvrhaDoznakeDrugiRed).HasMaxLength(25);

                entity.Property(e => e.SvrhaDoznakePrviRed).HasMaxLength(15);

                entity.Property(e => e.SvrhaDoznakeTreciRed).HasMaxLength(25);

                entity.Property(e => e.UplatilacDrugiRed).HasMaxLength(25);

                entity.Property(e => e.UplatilacPrviRed).HasMaxLength(25);

                entity.Property(e => e.VrstaPrihoda).HasMaxLength(10);

                entity.Property(e => e.VrstaUplate)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NaloziZaPlacanjePrintOptionsDetail>(entity =>
            {
                entity.HasKey(e => new { e.NalogZaPlacanjePrintOptionsId, e.VrstaPodatkaId })
                    .HasName("PK_dbo.NaloziZaPlacanjePrintOptionsDetail");

                entity.HasIndex(e => e.NalogZaPlacanjePrintOptionsId)
                    .HasName("IX_NalogZaPlacanjePrintOptionsId");

                entity.Property(e => e.NalogZaPlacanjePrintOptionsId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaPodatkaId)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.NalogZaPlacanjePrintOptions)
                    .WithMany(p => p.NaloziZaPlacanjePrintOptionsDetail)
                    .HasForeignKey(d => d.NalogZaPlacanjePrintOptionsId)
                    .HasConstraintName("FK_dbo.NaloziZaPlacanjePrintOptionsDetail_dbo.NaloziZaPlacanjePrintOptionsMaster_NalogZaPlacanjePrintOptionsId");
            });

            modelBuilder.Entity<NaloziZaPlacanjePrintOptionsMaster>(entity =>
            {
                entity.HasKey(e => e.NalogZaPlacanjePrintOptionsId)
                    .HasName("PK_dbo.NaloziZaPlacanjePrintOptionsMaster");

                entity.Property(e => e.NalogZaPlacanjePrintOptionsId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.OznakaIspredIznosa)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OznakaIzaIznosa)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PrinterName).HasMaxLength(100);
            });

            modelBuilder.Entity<NarudzbeniceDobavljacu>(entity =>
            {
                entity.HasKey(e => new { e.OrganizacionaJedinicaId, e.Broj })
                    .HasName("PK_dbo.NarudzbeniceDobavljacu");

                entity.HasIndex(e => e.DobavljacId)
                    .HasName("IX_DobavljacId");

                entity.HasIndex(e => e.OrganizacionaJedinicaId)
                    .HasName("IX_OrganizacionaJedinicaId");

                entity.HasIndex(e => e.TekstId)
                    .HasName("IX_TekstId");

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Broj)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.DobavljacId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.MjestoIsporuke).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.OsobaZaKontakt).HasMaxLength(100);

                entity.Property(e => e.TekstId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Telefon).HasMaxLength(100);

                entity.HasOne(d => d.Dobavljac)
                    .WithMany(p => p.NarudzbeniceDobavljacu)
                    .HasForeignKey(d => d.DobavljacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.NarudzbeniceDobavljacu_dbo.PoslovniPartneri_DobavljacId");

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.NarudzbeniceDobavljacu)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.NarudzbeniceDobavljacu_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");

                entity.HasOne(d => d.Tekst)
                    .WithMany(p => p.NarudzbeniceDobavljacu)
                    .HasForeignKey(d => d.TekstId)
                    .HasConstraintName("FK_dbo.NarudzbeniceDobavljacu_dbo.Tekstovi_TekstId");
            });

            modelBuilder.Entity<NarudzbeniceKupca>(entity =>
            {
                entity.HasKey(e => new { e.KomercijalistaId, e.BrojNarudzbenice })
                    .HasName("PK_dbo.NarudzbeniceKupca");

                entity.HasIndex(e => e.KomercijalistaId)
                    .HasName("IX_KomercijalistaId");

                entity.HasIndex(e => e.OrganizacionaJedinicaId)
                    .HasName("IX_OrganizacionaJedinicaId");

                entity.HasIndex(e => e.SkladistarId)
                    .HasName("IX_SkladistarId");

                entity.HasIndex(e => new { e.PoslovnaJedinicaId, e.KupacId })
                    .HasName("IX_PoslovnaJedinicaId_KupacId");

                entity.Property(e => e.KomercijalistaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.BrojNarudzbenice)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojFakture).HasMaxLength(20);

                entity.Property(e => e.DatumFakture).HasColumnType("datetime");

                entity.Property(e => e.DatumIsporuke).HasColumnType("datetime");

                entity.Property(e => e.DatumNarudzbenice).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.KupacId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Odobrio).HasMaxLength(50);

                entity.Property(e => e.OpisIsporuke).HasMaxLength(100);

                entity.Property(e => e.OpisNarudzbenice).HasMaxLength(200);

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OsobaZaKontakt).HasMaxLength(100);

                entity.Property(e => e.PoslovnaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SkladistarId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Telefon).HasMaxLength(100);

                entity.HasOne(d => d.Komercijalista)
                    .WithMany(p => p.NarudzbeniceKupca)
                    .HasForeignKey(d => d.KomercijalistaId)
                    .HasConstraintName("FK_dbo.NarudzbeniceKupca_dbo.Komercijalisti_KomercijalistaId");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.NarudzbeniceKupca)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.NarudzbeniceKupca_dbo.PoslovniPartneri_KupacId");

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.NarudzbeniceKupca)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.NarudzbeniceKupca_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");

                entity.HasOne(d => d.Skladistar)
                    .WithMany(p => p.NarudzbeniceKupca)
                    .HasForeignKey(d => d.SkladistarId)
                    .HasConstraintName("FK_dbo.NarudzbeniceKupca_dbo.Skladistari_SkladistarId");

                entity.HasOne(d => d.PoslovneJedinice)
                    .WithMany(p => p.NarudzbeniceKupca)
                    .HasForeignKey(d => new { d.PoslovnaJedinicaId, d.KupacId })
                    .HasConstraintName("FK_dbo.NarudzbeniceKupca_dbo.PoslovneJedinice_PoslovnaJedinicaId_KupacId");
            });

            modelBuilder.Entity<NasloviRacuna>(entity =>
            {
                entity.HasKey(e => e.VrstaRacunaId)
                    .HasName("PK_dbo.NasloviRacuna");

                entity.Property(e => e.VrstaRacunaId)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naslov).HasMaxLength(100);

                entity.Property(e => e.NaslovStorno).HasMaxLength(100);
            });

            modelBuilder.Entity<Normativi>(entity =>
            {
                entity.HasKey(e => e.GotovProizvodId)
                    .HasName("PK_dbo.Normativi");

                entity.HasIndex(e => e.GotovProizvodId)
                    .HasName("IX_GotovProizvodId");

                entity.Property(e => e.GotovProizvodId)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.MaloprodajnaCijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpciTrosakProizvodnjeIznos).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OpciTrosakProizvodnjePostotak).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OpisNormativa).HasMaxLength(100);

                entity.Property(e => e.VeleprodajnaCijena).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.GotovProizvod)
                    .WithOne(p => p.Normativi)
                    .HasForeignKey<Normativi>(d => d.GotovProizvodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Normativi_dbo.Artikli_GotovProizvodId");
            });

            modelBuilder.Entity<OblikOrganizovanja>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.OblikOrganizovanja");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.SkraceniNaziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ObrazacSl2>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.RedniBroj })
                    .HasName("PK_dbo.ObrazacSL2");

                entity.ToTable("ObrazacSL2");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.Stranac)
                    .HasName("IX_Stranac");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RedniBroj)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.DatumPovrata).HasColumnType("datetime");

                entity.Property(e => e.DatumnPrijema).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IznosPovrata).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.ObrazacSl2)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ObrazacSL2_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.StranacNavigation)
                    .WithMany(p => p.ObrazacSl2)
                    .HasForeignKey(d => d.Stranac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ObrazacSL2_dbo.StraniDrzavljani_Stranac");
            });

            modelBuilder.Entity<Odjeli>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Odjeli");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Opcine>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Opcine");

                entity.HasIndex(e => e.IdKanton)
                    .HasName("IX_IdKanton");

                entity.HasIndex(e => e.IdRegija)
                    .HasName("IX_IdRegija");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.IdKanton)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.IdRegija)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdKantonNavigation)
                    .WithMany(p => p.Opcine)
                    .HasForeignKey(d => d.IdKanton)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Opcine_dbo.Kantoni_IdKanton");

                entity.HasOne(d => d.IdRegijaNavigation)
                    .WithMany(p => p.Opcine)
                    .HasForeignKey(d => d.IdRegija)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Opcine_dbo.Regije_IdRegija");
            });

            modelBuilder.Entity<OrganizacioneJedinice>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.OrganizacioneJedinice");

                entity.HasIndex(e => e.GrupaNalogaGotovinskeProdaje)
                    .HasName("IX_GrupaNalogaGotovinskeProdaje");

                entity.HasIndex(e => e.GrupaNalogaKalkulacija)
                    .HasName("IX_GrupaNalogaKalkulacija");

                entity.HasIndex(e => e.GrupaNalogaKnjiznaObavijestDobavljaci)
                    .HasName("IX_GrupaNalogaKnjiznaObavijestDobavljaci");

                entity.HasIndex(e => e.GrupaNalogaKnjiznaObavijestKupci)
                    .HasName("IX_GrupaNalogaKnjiznaObavijestKupci");

                entity.HasIndex(e => e.GrupaNalogaKompenzacije)
                    .HasName("IX_GrupaNalogaKompenzacije");

                entity.HasIndex(e => e.GrupaNalogaOtipsDoDozvoljenogIznosa)
                    .HasName("IX_GrupaNalogaOtipsDoDozvoljenogIznosa");

                entity.HasIndex(e => e.GrupaNalogaOtpisPrekoDozvoljenogIznosa)
                    .HasName("IX_GrupaNalogaOtpisPrekoDozvoljenogIznosa");

                entity.HasIndex(e => e.GrupaNalogaRacun)
                    .HasName("IX_GrupaNalogaRacun");

                entity.HasIndex(e => e.GrupaNalogaZapisnika)
                    .HasName("IX_GrupaNalogaZapisnika");

                entity.HasIndex(e => e.KontoAkciza)
                    .HasName("IX_KontoAkciza");

                entity.HasIndex(e => e.KontoDomaciDobavljac)
                    .HasName("IX_KontoDomaciDobavljac");

                entity.HasIndex(e => e.KontoDomaciKupac)
                    .HasName("IX_KontoDomaciKupac");

                entity.HasIndex(e => e.KontoInostraniDobavljac)
                    .HasName("IX_KontoInostraniDobavljac");

                entity.HasIndex(e => e.KontoInostraniKupac)
                    .HasName("IX_KontoInostraniKupac");

                entity.HasIndex(e => e.KontoOtpis)
                    .HasName("IX_KontoOtpis");

                entity.HasIndex(e => e.KontoPazarCek)
                    .HasName("IX_KontoPazarCek");

                entity.HasIndex(e => e.KontoPazarGotovina)
                    .HasName("IX_KontoPazarGotovina");

                entity.HasIndex(e => e.KontoPazarKartica)
                    .HasName("IX_KontoPazarKartica");

                entity.HasIndex(e => e.KontoPazarVirman)
                    .HasName("IX_KontoPazarVirman");

                entity.HasIndex(e => e.KontoPrihodOdProdajeRobe)
                    .HasName("IX_KontoPrihodOdProdajeRobe");

                entity.HasIndex(e => e.KontoPrihodOdProdajeUsluga)
                    .HasName("IX_KontoPrihodOdProdajeUsluga");

                entity.HasIndex(e => e.KontoRealiziraniPdv)
                    .HasName("IX_KontoRealiziraniPDV");

                entity.HasIndex(e => e.KontoRealiziraniPdvneobveznik)
                    .HasName("IX_KontoRealiziraniPDVNeobveznik");

                entity.HasIndex(e => e.KontoRuc)
                    .HasName("IX_KontoRUC");

                entity.HasIndex(e => e.KontoTrosakOdNabave)
                    .HasName("IX_KontoTrosakOdNabave");

                entity.HasIndex(e => e.KontoUkalkulisaniPdv)
                    .HasName("IX_KontoUkalkulisaniPDV");

                entity.HasIndex(e => e.KontoUlazniPdvdomaci)
                    .HasName("IX_KontoUlazniPDVDomaci");

                entity.HasIndex(e => e.KontoUlazniPdvinostrani)
                    .HasName("IX_KontoUlazniPDVInostrani");

                entity.HasIndex(e => e.KontoZaliha)
                    .HasName("IX_KontoZaliha");

                entity.HasIndex(e => e.KontoZavisniTrosak)
                    .HasName("IX_KontoZavisniTrosak");

                entity.HasIndex(e => e.SifraOpstina)
                    .HasName("IX_SifraOpstina");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Adresa).HasMaxLength(50);

                entity.Property(e => e.DozvoljenoViseCijenaUmaloprodaji).HasColumnName("DozvoljenoViseCijenaUMaloprodaji");

                entity.Property(e => e.GrupaNalogaGotovinskeProdaje)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.GrupaNalogaKalkulacija)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.GrupaNalogaKnjiznaObavijestDobavljaci)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.GrupaNalogaKnjiznaObavijestKupci)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.GrupaNalogaKompenzacije)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.GrupaNalogaOtipsDoDozvoljenogIznosa)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.GrupaNalogaOtpisPrekoDozvoljenogIznosa)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.GrupaNalogaRacun)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.GrupaNalogaZapisnika)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.IzlazIzVp)
                    .IsRequired()
                    .HasColumnName("IzlazIzVP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.KontoAkciza)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoDomaciDobavljac)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoDomaciKupac)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoInostraniDobavljac)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoInostraniKupac)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoOtpis)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoPazarCek)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoPazarGotovina)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoPazarKartica)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoPazarVirman)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoPrihodOdProdajeRobe)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoPrihodOdProdajeUsluga)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoRealiziraniPdv)
                    .HasColumnName("KontoRealiziraniPDV")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoRealiziraniPdvneobveznik)
                    .HasColumnName("KontoRealiziraniPDVNeobveznik")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoRuc)
                    .HasColumnName("KontoRUC")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoTrosakOdNabave)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoUkalkulisaniPdv)
                    .HasColumnName("KontoUkalkulisaniPDV")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoUlazniPdvdomaci)
                    .HasColumnName("KontoUlazniPDVDomaci")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoUlazniPdvinostrani)
                    .HasColumnName("KontoUlazniPDVInostrani")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoZaliha)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoZavisniTrosak)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PretragaArtikla)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.SifraOpstina)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Vrsta)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ZaokruzenjeProdajneCijene)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.GrupaNalogaGotovinskeProdajeNavigation)
                    .WithMany(p => p.OrganizacioneJediniceGrupaNalogaGotovinskeProdajeNavigation)
                    .HasForeignKey(d => d.GrupaNalogaGotovinskeProdaje)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.GrupeNalogaGK_GrupaNalogaGotovinskeProdaje");

                entity.HasOne(d => d.GrupaNalogaKalkulacijaNavigation)
                    .WithMany(p => p.OrganizacioneJediniceGrupaNalogaKalkulacijaNavigation)
                    .HasForeignKey(d => d.GrupaNalogaKalkulacija)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.GrupeNalogaGK_GrupaNalogaKalkulacija");

                entity.HasOne(d => d.GrupaNalogaKnjiznaObavijestDobavljaciNavigation)
                    .WithMany(p => p.OrganizacioneJediniceGrupaNalogaKnjiznaObavijestDobavljaciNavigation)
                    .HasForeignKey(d => d.GrupaNalogaKnjiznaObavijestDobavljaci)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.GrupeNalogaGK_GrupaNalogaKnjiznaObavijestDobavljaci");

                entity.HasOne(d => d.GrupaNalogaKnjiznaObavijestKupciNavigation)
                    .WithMany(p => p.OrganizacioneJediniceGrupaNalogaKnjiznaObavijestKupciNavigation)
                    .HasForeignKey(d => d.GrupaNalogaKnjiznaObavijestKupci)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.GrupeNalogaGK_GrupaNalogaKnjiznaObavijestKupci");

                entity.HasOne(d => d.GrupaNalogaKompenzacijeNavigation)
                    .WithMany(p => p.OrganizacioneJediniceGrupaNalogaKompenzacijeNavigation)
                    .HasForeignKey(d => d.GrupaNalogaKompenzacije)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.GrupeNalogaGK_GrupaNalogaKompenzacije");

                entity.HasOne(d => d.GrupaNalogaOtipsDoDozvoljenogIznosaNavigation)
                    .WithMany(p => p.OrganizacioneJediniceGrupaNalogaOtipsDoDozvoljenogIznosaNavigation)
                    .HasForeignKey(d => d.GrupaNalogaOtipsDoDozvoljenogIznosa)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.GrupeNalogaGK_GrupaNalogaOtipsDoDozvoljenogIznosa");

                entity.HasOne(d => d.GrupaNalogaOtpisPrekoDozvoljenogIznosaNavigation)
                    .WithMany(p => p.OrganizacioneJediniceGrupaNalogaOtpisPrekoDozvoljenogIznosaNavigation)
                    .HasForeignKey(d => d.GrupaNalogaOtpisPrekoDozvoljenogIznosa)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.GrupeNalogaGK_GrupaNalogaOtpisPrekoDozvoljenogIznosa");

                entity.HasOne(d => d.GrupaNalogaRacunNavigation)
                    .WithMany(p => p.OrganizacioneJediniceGrupaNalogaRacunNavigation)
                    .HasForeignKey(d => d.GrupaNalogaRacun)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.GrupeNalogaGK_GrupaNalogaRacun");

                entity.HasOne(d => d.GrupaNalogaZapisnikaNavigation)
                    .WithMany(p => p.OrganizacioneJediniceGrupaNalogaZapisnikaNavigation)
                    .HasForeignKey(d => d.GrupaNalogaZapisnika)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.GrupeNalogaGK_GrupaNalogaZapisnika");

                entity.HasOne(d => d.KontoAkcizaNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoAkcizaNavigation)
                    .HasForeignKey(d => d.KontoAkciza)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoAkciza");

                entity.HasOne(d => d.KontoDomaciDobavljacNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoDomaciDobavljacNavigation)
                    .HasForeignKey(d => d.KontoDomaciDobavljac)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoDomaciDobavljac");

                entity.HasOne(d => d.KontoDomaciKupacNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoDomaciKupacNavigation)
                    .HasForeignKey(d => d.KontoDomaciKupac)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoDomaciKupac");

                entity.HasOne(d => d.KontoInostraniDobavljacNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoInostraniDobavljacNavigation)
                    .HasForeignKey(d => d.KontoInostraniDobavljac)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoInostraniDobavljac");

                entity.HasOne(d => d.KontoInostraniKupacNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoInostraniKupacNavigation)
                    .HasForeignKey(d => d.KontoInostraniKupac)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoInostraniKupac");

                entity.HasOne(d => d.KontoOtpisNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoOtpisNavigation)
                    .HasForeignKey(d => d.KontoOtpis)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoOtpis");

                entity.HasOne(d => d.KontoPazarCekNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoPazarCekNavigation)
                    .HasForeignKey(d => d.KontoPazarCek)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoPazarCek");

                entity.HasOne(d => d.KontoPazarGotovinaNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoPazarGotovinaNavigation)
                    .HasForeignKey(d => d.KontoPazarGotovina)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoPazarGotovina");

                entity.HasOne(d => d.KontoPazarKarticaNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoPazarKarticaNavigation)
                    .HasForeignKey(d => d.KontoPazarKartica)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoPazarKartica");

                entity.HasOne(d => d.KontoPazarVirmanNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoPazarVirmanNavigation)
                    .HasForeignKey(d => d.KontoPazarVirman)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoPazarVirman");

                entity.HasOne(d => d.KontoPrihodOdProdajeRobeNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoPrihodOdProdajeRobeNavigation)
                    .HasForeignKey(d => d.KontoPrihodOdProdajeRobe)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoPrihodOdProdajeRobe");

                entity.HasOne(d => d.KontoPrihodOdProdajeUslugaNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoPrihodOdProdajeUslugaNavigation)
                    .HasForeignKey(d => d.KontoPrihodOdProdajeUsluga)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoPrihodOdProdajeUsluga");

                entity.HasOne(d => d.KontoRealiziraniPdvNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoRealiziraniPdvNavigation)
                    .HasForeignKey(d => d.KontoRealiziraniPdv)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoRealiziraniPDV");

                entity.HasOne(d => d.KontoRealiziraniPdvneobveznikNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoRealiziraniPdvneobveznikNavigation)
                    .HasForeignKey(d => d.KontoRealiziraniPdvneobveznik)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoRealiziraniPDVNeobveznik");

                entity.HasOne(d => d.KontoRucNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoRucNavigation)
                    .HasForeignKey(d => d.KontoRuc)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoRUC");

                entity.HasOne(d => d.KontoTrosakOdNabaveNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoTrosakOdNabaveNavigation)
                    .HasForeignKey(d => d.KontoTrosakOdNabave)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoTrosakOdNabave");

                entity.HasOne(d => d.KontoUkalkulisaniPdvNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoUkalkulisaniPdvNavigation)
                    .HasForeignKey(d => d.KontoUkalkulisaniPdv)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoUkalkulisaniPDV");

                entity.HasOne(d => d.KontoUlazniPdvdomaciNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoUlazniPdvdomaciNavigation)
                    .HasForeignKey(d => d.KontoUlazniPdvdomaci)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoUlazniPDVDomaci");

                entity.HasOne(d => d.KontoUlazniPdvinostraniNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoUlazniPdvinostraniNavigation)
                    .HasForeignKey(d => d.KontoUlazniPdvinostrani)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoUlazniPDVInostrani");

                entity.HasOne(d => d.KontoZalihaNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoZalihaNavigation)
                    .HasForeignKey(d => d.KontoZaliha)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoZaliha");

                entity.HasOne(d => d.KontoZavisniTrosakNavigation)
                    .WithMany(p => p.OrganizacioneJediniceKontoZavisniTrosakNavigation)
                    .HasForeignKey(d => d.KontoZavisniTrosak)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.AnalitickaKonta_KontoZavisniTrosak");

                entity.HasOne(d => d.SifraOpstinaNavigation)
                    .WithMany(p => p.OrganizacioneJedinice)
                    .HasForeignKey(d => d.SifraOpstina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.OrganizacioneJedinice_dbo.Opcine_SifraOpstina");
            });

            modelBuilder.Entity<OtpremniceVeleprodajeUtoku>(entity =>
            {
                entity.HasKey(e => e.Broj)
                    .HasName("PK_dbo.OtpremniceVeleprodajeUToku");

                entity.ToTable("OtpremniceVeleprodajeUToku");

                entity.HasIndex(e => e.KupacId)
                    .HasName("IX_KupacId");

                entity.HasIndex(e => e.OrganizacionaJedinicaId)
                    .HasName("IX_OrganizacionaJedinicaId");

                entity.Property(e => e.Broj)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.KupacId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.OtpremniceVeleprodajeUtoku)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.OtpremniceVeleprodajeUToku_dbo.PoslovniPartneri_KupacId");

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.OtpremniceVeleprodajeUtoku)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.OtpremniceVeleprodajeUToku_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");
            });

            modelBuilder.Entity<Pdvprijave>(entity =>
            {
                entity.HasKey(e => e.Mjesec)
                    .HasName("PK_dbo.PDVPrijave");

                entity.ToTable("PDVPrijave");

                entity.Property(e => e.Mjesec)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumPdv)
                    .HasColumnName("DatumPDV")
                    .HasColumnType("datetime");

                entity.Property(e => e.IzlazniPdv51)
                    .HasColumnName("IzlazniPDV51")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzvozneIsporuke12).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KrajnjaPotrosnjaBrcko34).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KrajnjaPotrosnjaFbiH32)
                    .HasColumnName("KrajnjaPotrosnjaFBiH32")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KrajnjaPotrosnjaRs33)
                    .HasColumnName("KrajnjaPotrosnjaRS33")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavkeOdPoljoprivrednika23).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OporeziveIsporuke11).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OslobodjenoPdv13)
                    .HasColumnName("OslobodjenoPDV13")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StandardneNabavke21).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UlazniPdv41)
                    .HasColumnName("UlazniPDV41")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UlazniPdvnaUvoz42)
                    .HasColumnName("UlazniPDVNaUvoz42")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UlazniPdvpausal43)
                    .HasColumnName("UlazniPDVPausal43")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UvozneNabavke22).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PodgrupeArtikala>(entity =>
            {
                entity.HasKey(e => new { e.SifraGrupe, e.Sifra })
                    .HasName("PK_dbo.PodgrupeArtikala");

                entity.HasIndex(e => e.SifraGrupe)
                    .HasName("IX_SifraGrupe");

                entity.Property(e => e.SifraGrupe)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Sifra).HasMaxLength(3);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.SifraGrupeNavigation)
                    .WithMany(p => p.PodgrupeArtikala)
                    .HasForeignKey(d => d.SifraGrupe)
                    .HasConstraintName("FK_dbo.PodgrupeArtikala_dbo.GrupeArtikala_SifraGrupe");
            });

            modelBuilder.Entity<PodrucjeDjelatnosti>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.PodrucjeDjelatnosti");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PomocnePopisneListe>(entity =>
            {
                entity.HasKey(e => new { e.SifraOrganizacioneJedinice, e.SifraArtikla, e.Id })
                    .HasName("PK_dbo.PomocnePopisneListe");

                entity.HasIndex(e => e.SifraArtikla)
                    .HasName("IX_SifraArtikla");

                entity.HasIndex(e => e.SifraOrganizacioneJedinice)
                    .HasName("IX_SifraOrganizacioneJedinice");

                entity.Property(e => e.SifraOrganizacioneJedinice)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraArtikla)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MaloprodajnaCijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PopisnaKolicina).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.SifraArtiklaNavigation)
                    .WithMany(p => p.PomocnePopisneListe)
                    .HasForeignKey(d => d.SifraArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PomocnePopisneListe_dbo.Artikli_SifraArtikla");

                entity.HasOne(d => d.SifraOrganizacioneJediniceNavigation)
                    .WithMany(p => p.PomocnePopisneListe)
                    .HasForeignKey(d => d.SifraOrganizacioneJedinice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PomocnePopisneListe_dbo.OrganizacioneJedinice_SifraOrganizacioneJedinice");
            });

            modelBuilder.Entity<PomocnePopisneListeRepromaterijala>(entity =>
            {
                entity.HasKey(e => new { e.OrganizacionaJedinicaId, e.RepromaterijalId, e.Id })
                    .HasName("PK_dbo.PomocnePopisneListeRepromaterijala");

                entity.HasIndex(e => e.OrganizacionaJedinicaId)
                    .HasName("IX_OrganizacionaJedinicaId");

                entity.HasIndex(e => e.RepromaterijalId)
                    .HasName("IX_RepromaterijalId");

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RepromaterijalId)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.DatumPrvogUlaza).HasColumnType("datetime");

                entity.Property(e => e.DatumZadnjegUlaza).HasColumnType("datetime");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OpisPrometa).HasMaxLength(100);

                entity.Property(e => e.PopisnaKolicina).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.PomocnePopisneListeRepromaterijala)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PomocnePopisneListeRepromaterijala_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");

                entity.HasOne(d => d.Repromaterijal)
                    .WithMany(p => p.PomocnePopisneListeRepromaterijala)
                    .HasForeignKey(d => d.RepromaterijalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PomocnePopisneListeRepromaterijala_dbo.Repromaterijal_RepromaterijalId");
            });

            modelBuilder.Entity<PomocnePopisneListeVp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOrganizacioneJedinice, e.SifraArtikla, e.Id })
                    .HasName("PK_dbo.PomocnePopisneListeVP");

                entity.ToTable("PomocnePopisneListeVP");

                entity.HasIndex(e => e.SifraArtikla)
                    .HasName("IX_SifraArtikla");

                entity.HasIndex(e => e.SifraOrganizacioneJedinice)
                    .HasName("IX_SifraOrganizacioneJedinice");

                entity.Property(e => e.SifraOrganizacioneJedinice)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraArtikla)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojKontrolePrveSerije).HasMaxLength(20);

                entity.Property(e => e.BrojKontroleSvakeSerije).HasMaxLength(20);

                entity.Property(e => e.BrojSerije).HasMaxLength(30);

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.DatumPrvogUlaza).HasColumnType("datetime");

                entity.Property(e => e.DatumZadnjegUlaza).HasColumnType("datetime");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OpisPrometa).HasMaxLength(100);

                entity.Property(e => e.PopisnaKolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.RokTrajanja).HasColumnType("datetime");

                entity.Property(e => e.VeleprodajnaCijena).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.SifraArtiklaNavigation)
                    .WithMany(p => p.PomocnePopisneListeVp)
                    .HasForeignKey(d => d.SifraArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PomocnePopisneListeVP_dbo.Artikli_SifraArtikla");

                entity.HasOne(d => d.SifraOrganizacioneJediniceNavigation)
                    .WithMany(p => p.PomocnePopisneListeVp)
                    .HasForeignKey(d => d.SifraOrganizacioneJedinice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PomocnePopisneListeVP_dbo.OrganizacioneJedinice_SifraOrganizacioneJedinice");
            });

            modelBuilder.Entity<PorezneGrupe>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.PorezneGrupe");

                entity.HasIndex(e => e.KontoUlazniPdvdomaci)
                    .HasName("IX_KontoUlazniPDVDomaci");

                entity.HasIndex(e => e.KontoUlazniPdvuvoz)
                    .HasName("IX_KontoUlazniPDVUvoz");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.FiskalnaOznaka)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.KontoUlazniPdvdomaci)
                    .HasColumnName("KontoUlazniPDVDomaci")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoUlazniPdvuvoz)
                    .HasColumnName("KontoUlazniPDVUvoz")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Stopa).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.KontoUlazniPdvdomaciNavigation)
                    .WithMany(p => p.PorezneGrupeKontoUlazniPdvdomaciNavigation)
                    .HasForeignKey(d => d.KontoUlazniPdvdomaci)
                    .HasConstraintName("FK_dbo.PorezneGrupe_dbo.AnalitickaKonta_KontoUlazniPDVDomaci");

                entity.HasOne(d => d.KontoUlazniPdvuvozNavigation)
                    .WithMany(p => p.PorezneGrupeKontoUlazniPdvuvozNavigation)
                    .HasForeignKey(d => d.KontoUlazniPdvuvoz)
                    .HasConstraintName("FK_dbo.PorezneGrupe_dbo.AnalitickaKonta_KontoUlazniPDVUvoz");
            });

            modelBuilder.Entity<PosPostavke>(entity =>
            {
                entity.HasKey(e => e.OrganizacionaJedinicaId)
                    .HasName("PK_dbo.PosPostavke");

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojZnakovaKojiOdredujuArtikl).HasColumnName("BrojZnakovaKojiODredujuArtikl");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UkljucenaZvucnaSignalizacija)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ZamjenskiArtiklZaFakturisanje1).HasMaxLength(6);

                entity.Property(e => e.ZamjenskiArtiklZaFakturisanje2).HasMaxLength(6);

                entity.Property(e => e.ZamjenskiArtiklZaFakturisanje3).HasMaxLength(6);
            });

            modelBuilder.Entity<PoslovneJedinice>(entity =>
            {
                entity.HasKey(e => new { e.Sifra, e.SifraPp })
                    .HasName("PK_dbo.PoslovneJedinice");

                entity.HasIndex(e => e.PttBroj)
                    .HasName("IX_PttBroj");

                entity.HasIndex(e => e.SifraPp)
                    .HasName("IX_SifraPP");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraPp)
                    .HasColumnName("SifraPP")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PttBroj)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.HasOne(d => d.PttBrojNavigation)
                    .WithMany(p => p.PoslovneJedinice)
                    .HasForeignKey(d => d.PttBroj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PoslovneJedinice_dbo.Mjesta_PttBroj");

                entity.HasOne(d => d.SifraPpNavigation)
                    .WithMany(p => p.PoslovneJedinice)
                    .HasForeignKey(d => d.SifraPp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PoslovneJedinice_dbo.PoslovniPartneri_SifraPP");
            });

            modelBuilder.Entity<PoslovniPartneri>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.PoslovniPartneri");

                entity.HasIndex(e => e.DjelatnostId)
                    .HasName("IX_DjelatnostId");

                entity.HasIndex(e => e.DrzavaId)
                    .HasName("IX_DrzavaId");

                entity.HasIndex(e => e.MjestoId)
                    .HasName("IX_MjestoId");

                entity.HasIndex(e => e.OblikOrganizacije)
                    .HasName("IX_OblikOrganizacije");

                entity.HasIndex(e => e.OpcinaId)
                    .HasName("IX_OpcinaId");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AdresaNaRacunu1).HasMaxLength(50);

                entity.Property(e => e.AdresaNaRacunu2).HasMaxLength(50);

                entity.Property(e => e.AdresaNaRacunu3).HasMaxLength(50);

                entity.Property(e => e.AdresaNaRacunu4).HasMaxLength(50);

                entity.Property(e => e.BrojUgovoraOsuradnji)
                    .HasColumnName("BrojUgovoraOSuradnji")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.DatumUgovoraOsuradnji)
                    .HasColumnName("DatumUgovoraOSuradnji")
                    .HasColumnType("datetime");

                entity.Property(e => e.Direktor).HasMaxLength(50);

                entity.Property(e => e.DjelatnostId)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.DomaciInostrani)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.DozvoljenoZiralnoPlacanjeMp).HasColumnName("DozvoljenoZiralnoPlacanjeMP");

                entity.Property(e => e.DrzavaId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Idbroj)
                    .HasColumnName("IDBroj")
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.InostraniIdbroj)
                    .HasColumnName("InostraniIDBroj")
                    .HasMaxLength(15);

                entity.Property(e => e.InostraniPdvbroj)
                    .HasColumnName("InostraniPDVBroj")
                    .HasMaxLength(15);

                entity.Property(e => e.InostranoMjesto).HasMaxLength(50);

                entity.Property(e => e.Jmbg)
                    .HasColumnName("JMBG")
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.KontaktOsoba).HasMaxLength(50);

                entity.Property(e => e.MjestoId)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.MjestoRegistracije).HasMaxLength(50);

                entity.Property(e => e.Mobitel).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Napomena).HasMaxLength(4000);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OblikOrganizacije)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.OpcinaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Pdvbroj)
                    .HasColumnName("PDVBroj")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Pdvstatus).HasColumnName("PDVStatus");

                entity.Property(e => e.RegistarskiBroj).HasMaxLength(20);

                entity.Property(e => e.SendSms).HasColumnName("SendSMS");

                entity.Property(e => e.SkraceniNaziv).HasMaxLength(30);

                entity.Property(e => e.TekstNaNalogu1)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.TekstNaNalogu2)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TekstNaNalogu3)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.Property(e => e.UgovoreniRabat).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Vlasnik).HasMaxLength(50);

                entity.Property(e => e.VrstaPoslovnogPartnera)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Web).HasMaxLength(50);

                entity.HasOne(d => d.Djelatnost)
                    .WithMany(p => p.PoslovniPartneri)
                    .HasForeignKey(d => d.DjelatnostId)
                    .HasConstraintName("FK_dbo.PoslovniPartneri_dbo.Djelatnosti_DjelatnostId");

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.PoslovniPartneri)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PoslovniPartneri_dbo.Drzave_DrzavaId");

                entity.HasOne(d => d.Mjesto)
                    .WithMany(p => p.PoslovniPartneri)
                    .HasForeignKey(d => d.MjestoId)
                    .HasConstraintName("FK_dbo.PoslovniPartneri_dbo.Mjesta_MjestoId");

                entity.HasOne(d => d.OblikOrganizacijeNavigation)
                    .WithMany(p => p.PoslovniPartneri)
                    .HasForeignKey(d => d.OblikOrganizacije)
                    .HasConstraintName("FK_dbo.PoslovniPartneri_dbo.OblikOrganizovanja_OblikOrganizacije");

                entity.HasOne(d => d.Opcina)
                    .WithMany(p => p.PoslovniPartneri)
                    .HasForeignKey(d => d.OpcinaId)
                    .HasConstraintName("FK_dbo.PoslovniPartneri_dbo.Opcine_OpcinaId");
            });

            modelBuilder.Entity<Pospisaci>(entity =>
            {
                entity.ToTable("POSPisaci");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CommandBoldOff)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandBoldOn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandCut)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandDoubleHeightOff)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandDoubleHeightOn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandDoubleOff)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CommandDoubleOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CommandDoubleWidthOff)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandDoubleWidthOn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandInitialize)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandOpenDrawer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandUnderlineOff)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommandUnderlineOn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Driver)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Footer1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Footer2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Footer3)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GrupeZaTalon)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Header1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Header2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Header3)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Header4)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrintKind)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Workstation)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PostavkaIspisaKnjiznihObavijesti>(entity =>
            {
                entity.HasKey(e => new { e.OrganizacionaJedinicaId, e.VrstaKnjizneObavijestiId })
                    .HasName("PK_dbo.PostavkaIspisaKnjiznihObavijesti");

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaKnjizneObavijestiId)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojFiskalnihDokumenataUgrupi).HasColumnName("BrojFiskalnihDokumenataUGrupi");

                entity.Property(e => e.FormatKnjizneObavijestiId)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.IspisUdomacojValuti).HasColumnName("IspisUDomacojValuti");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ValutaId)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PostavkaIspisaRacuna>(entity =>
            {
                entity.HasKey(e => e.OrganizacionaJedinicaId)
                    .HasName("PK_dbo.PostavkaIspisaRacuna");

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojDecimalaIznos).HasDefaultValueSql("((2))");

                entity.Property(e => e.BrojFiskalnihDokumenataUgrupi).HasColumnName("BrojFiskalnihDokumenataUGrupi");

                entity.Property(e => e.FormatRacunaId)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.IspisRacunaUposlovneSvrheNaFiskalniPisac).HasColumnName("IspisRacunaUPoslovneSvrheNaFiskalniPisac");

                entity.Property(e => e.IspisUdomacojValuti).HasColumnName("IspisUDomacojValuti");

                entity.Property(e => e.KataloskaOznakaNaslov).HasMaxLength(25);

                entity.Property(e => e.KlasifikacijaNaslov).HasMaxLength(25);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProizvodjacNaslov).HasMaxLength(25);

                entity.Property(e => e.RacunMpnaFiskalniUjednojStavci).HasColumnName("RacunMPNaFiskalniUJednojStavci");

                entity.Property(e => e.ValutaId)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PostavkaIzvoznihRacuna>(entity =>
            {
                entity.HasKey(e => e.OrganizacionaJedinicaId)
                    .HasName("PK_dbo.PostavkaIzvoznihRacuna");

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinObracunaPdva)
                    .HasColumnName("NacinObracunaPDVa")
                    .HasMaxLength(1);

                entity.Property(e => e.PoreznaGrupaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PrimjenitiOvajNacinObracunaPdva).HasColumnName("PrimjenitiOvajNacinObracunaPDVa");

                entity.Property(e => e.TekstKojiSeDodajeNazivuArtikla)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Postavke>(entity =>
            {
                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.EkifKufFolder)
                    .HasColumnName("EKifKufFolder")
                    .HasMaxLength(100);

                entity.Property(e => e.EkifKufFolderAddClientSubFolder).HasColumnName("EKifKufFolderAddClientSubFolder");

                entity.Property(e => e.EkstenzijaDatotekeKojaSePrati).HasMaxLength(3);

                entity.Property(e => e.EkstenzijaObradeneDatoteke).HasMaxLength(3);

                entity.Property(e => e.EmailBcc)
                    .HasColumnName("EmailBCC")
                    .HasMaxLength(250);

                entity.Property(e => e.EmailBody).HasMaxLength(250);

                entity.Property(e => e.EmailCc)
                    .HasColumnName("EmailCC")
                    .HasMaxLength(250);

                entity.Property(e => e.EmailFrom).HasMaxLength(50);

                entity.Property(e => e.EmailHost).HasMaxLength(30);

                entity.Property(e => e.EmailPassword).HasMaxLength(50);

                entity.Property(e => e.EmailSendError).HasMaxLength(100);

                entity.Property(e => e.EmailSsl).HasColumnName("EmailSSL");

                entity.Property(e => e.EmailSubject).HasMaxLength(50);

                entity.Property(e => e.EmailUserName).HasMaxLength(30);

                entity.Property(e => e.FormiranjeVezeUprometima)
                    .IsRequired()
                    .HasColumnName("FormiranjeVezeUPrometima")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ForsiratiFormiranjeMpkalkulacijePriPrenosu).HasColumnName("ForsiratiFormiranjeMPKalkulacijePriPrenosu");

                entity.Property(e => e.FtpKorisnickoIme).HasMaxLength(50);

                entity.Property(e => e.FtpLokalnaMapa).HasMaxLength(100);

                entity.Property(e => e.FtpLozinka).HasMaxLength(50);

                entity.Property(e => e.FtpMapaPosluzitelja).HasMaxLength(100);

                entity.Property(e => e.FtpPosluzitelj).HasMaxLength(50);

                entity.Property(e => e.MapaOdgodeneTransakcije).HasMaxLength(100);

                entity.Property(e => e.MapaTrenutneTransakcije).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinFormiranjaImenaDatotekaBilanci)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.NacinUpravljanjaBp)
                    .HasColumnName("NacinUpravljanjaBP")
                    .HasMaxLength(1);

                entity.Property(e => e.PrazanObrazacFiafileName).HasColumnName("PrazanObrazacFIAFileName");

                entity.Property(e => e.PrefiksUimenuDatoteke)
                    .HasColumnName("PrefiksUImenuDatoteke")
                    .HasMaxLength(50);

                entity.Property(e => e.PrenosDatumaGk)
                    .IsRequired()
                    .HasColumnName("PrenosDatumaGK")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrenosOpisaGk)
                    .IsRequired()
                    .HasColumnName("PrenosOpisaGK")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RezimRada).HasMaxLength(1);

                entity.Property(e => e.Separator).HasMaxLength(1);

                entity.Property(e => e.SerialPortName).HasMaxLength(4);

                entity.Property(e => e.SifraArtikla1).HasMaxLength(6);

                entity.Property(e => e.SifraArtikla2).HasMaxLength(6);

                entity.Property(e => e.SifraArtikla3).HasMaxLength(6);

                entity.Property(e => e.SifraArtikla4).HasMaxLength(6);

                entity.Property(e => e.SifraArtikla5).HasMaxLength(6);

                entity.Property(e => e.SifraArtikla6).HasMaxLength(6);

                entity.Property(e => e.SifraArtikla7).HasMaxLength(6);

                entity.Property(e => e.SifraArtikla8).HasMaxLength(6);

                entity.Property(e => e.SifraArtikla9).HasMaxLength(6);

                entity.Property(e => e.SifraArtiklaPumpe1).HasMaxLength(6);

                entity.Property(e => e.SifraArtiklaPumpe2).HasMaxLength(6);

                entity.Property(e => e.SifraArtiklaPumpe3).HasMaxLength(6);

                entity.Property(e => e.SifraArtiklaPumpe4).HasMaxLength(6);

                entity.Property(e => e.SifraArtiklaPumpe5).HasMaxLength(6);

                entity.Property(e => e.SifraArtiklaPumpe6).HasMaxLength(6);

                entity.Property(e => e.SifraArtiklaPumpe7).HasMaxLength(6);

                entity.Property(e => e.SifraArtiklaPumpe8).HasMaxLength(6);

                entity.Property(e => e.SifraArtiklaPumpe9).HasMaxLength(6);

                entity.Property(e => e.SifraOrganizacioneJedinice).HasMaxLength(3);

                entity.Property(e => e.SkinName).HasMaxLength(50);
            });

            modelBuilder.Entity<Potrosaci>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Potrosaci");

                entity.HasIndex(e => e.PttBroj)
                    .HasName("IX_PttBroj");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Adresa).HasMaxLength(50);

                entity.Property(e => e.DatumOdjave).HasColumnType("datetime");

                entity.Property(e => e.DatumPrijave).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Mobitel).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostotakPopusta).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PttBroj)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.HasOne(d => d.PttBrojNavigation)
                    .WithMany(p => p.Potrosaci)
                    .HasForeignKey(d => d.PttBroj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Potrosaci_dbo.Mjesta_PttBroj");
            });

            modelBuilder.Entity<PovremeniKupci>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.PovremeniKupci");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mjesto)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PredlosciPrometaBlagajne>(entity =>
            {
                entity.HasIndex(e => e.CashFlowItemId)
                    .HasName("IX_CashFlowItemId");

                entity.HasIndex(e => e.SifraKonto)
                    .HasName("IX_SifraKonto");

                entity.HasIndex(e => e.SifraPartnera)
                    .HasName("IX_SifraPartnera");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CashFlowItemId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SifraKonto)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.SifraPartnera)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.VrstaDokumenta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.CashFlowItem)
                    .WithMany(p => p.PredlosciPrometaBlagajne)
                    .HasForeignKey(d => d.CashFlowItemId)
                    .HasConstraintName("FK_dbo.PredlosciPrometaBlagajne_dbo.CashFlowItems_CashFlowItemId");

                entity.HasOne(d => d.SifraKontoNavigation)
                    .WithMany(p => p.PredlosciPrometaBlagajne)
                    .HasForeignKey(d => d.SifraKonto)
                    .HasConstraintName("FK_dbo.PredlosciPrometaBlagajne_dbo.AnalitickaKonta_SifraKonto");

                entity.HasOne(d => d.SifraPartneraNavigation)
                    .WithMany(p => p.PredlosciPrometaBlagajne)
                    .HasForeignKey(d => d.SifraPartnera)
                    .HasConstraintName("FK_dbo.PredlosciPrometaBlagajne_dbo.PoslovniPartneri_SifraPartnera");
            });

            modelBuilder.Entity<PresjeciStanjaMp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOrganizacioneJedinice, e.SifraArtikla, e.Id })
                    .HasName("PK_dbo.PresjeciStanjaMP");

                entity.ToTable("PresjeciStanjaMP");

                entity.HasIndex(e => e.SifraArtikla)
                    .HasName("IX_SifraArtikla");

                entity.HasIndex(e => e.SifraOrganizacioneJedinice)
                    .HasName("IX_SifraOrganizacioneJedinice");

                entity.Property(e => e.SifraOrganizacioneJedinice)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraArtikla)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MaloprodajnaCijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavnaCijena).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.SifraArtiklaNavigation)
                    .WithMany(p => p.PresjeciStanjaMp)
                    .HasForeignKey(d => d.SifraArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PresjeciStanjaMP_dbo.Artikli_SifraArtikla");

                entity.HasOne(d => d.SifraOrganizacioneJediniceNavigation)
                    .WithMany(p => p.PresjeciStanjaMp)
                    .HasForeignKey(d => d.SifraOrganizacioneJedinice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PresjeciStanjaMP_dbo.OrganizacioneJedinice_SifraOrganizacioneJedinice");
            });

            modelBuilder.Entity<PridruzenaKonta>(entity =>
            {
                entity.HasKey(e => new { e.OrganizacionaJedinicaId, e.VrstaKnjizenjaId })
                    .HasName("PK_dbo.PridruzenaKonta");

                entity.HasIndex(e => e.KontoId)
                    .HasName("IX_KontoId");

                entity.HasIndex(e => e.OrganizacionaJedinicaId)
                    .HasName("IX_OrganizacionaJedinicaId");

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaKnjizenjaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.KontoId)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Konto)
                    .WithMany(p => p.PridruzenaKonta)
                    .HasForeignKey(d => d.KontoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PridruzenaKonta_dbo.AnalitickaKonta_KontoId");

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.PridruzenaKonta)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PridruzenaKonta_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");
            });

            modelBuilder.Entity<PridruzeneGrupeNaloga>(entity =>
            {
                entity.HasKey(e => new { e.OrganizacionaJedinicaId, e.VrstaDokumentaId })
                    .HasName("PK_dbo.PridruzeneGrupeNaloga");

                entity.HasIndex(e => e.GrupaNalogaId)
                    .HasName("IX_GrupaNalogaId");

                entity.HasIndex(e => e.OrganizacionaJedinicaId)
                    .HasName("IX_OrganizacionaJedinicaId");

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaDokumentaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.GrupaNalogaId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.GrupaNaloga)
                    .WithMany(p => p.PridruzeneGrupeNaloga)
                    .HasForeignKey(d => d.GrupaNalogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PridruzeneGrupeNaloga_dbo.GrupeNalogaGK_GrupaNalogaId");

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.PridruzeneGrupeNaloga)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PridruzeneGrupeNaloga_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");
            });

            modelBuilder.Entity<PrintedReports>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.PrintedReports");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Iso)
                    .IsRequired()
                    .HasColumnName("ISO")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naslov)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PrintThisIso).HasColumnName("PrintThisISO");

                entity.Property(e => e.ZaglavljeZaOstale).IsRequired();

                entity.Property(e => e.ZaglavljeZaPrvu).IsRequired();
            });

            modelBuilder.Entity<PripremljeniRacuni>(entity =>
            {
                entity.HasKey(e => e.PripremljeniRacunId)
                    .HasName("PK_dbo.PripremljeniRacuni");

                entity.HasIndex(e => e.KupacId)
                    .HasName("IX_KupacId");

                entity.HasIndex(e => e.SifraGrupePripremljenihRacuna)
                    .HasName("IX_SifraGrupePripremljenihRacuna");

                entity.HasIndex(e => e.SifraKomercijaliste)
                    .HasName("IX_SifraKomercijaliste");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.SifraPorezneGrupe)
                    .HasName("IX_SifraPorezneGrupe");

                entity.HasIndex(e => e.SifraTeksta)
                    .HasName("IX_SifraTeksta");

                entity.Property(e => e.PripremljeniRacunId)
                    .HasMaxLength(5)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojNarudzbe).HasMaxLength(50);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DatumNarudzbe).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.JedinicaMjere)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.KupacId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.MjesecFakturisanja)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.NacinObracunaPdva)
                    .IsRequired()
                    .HasColumnName("NacinObracunaPDVa")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NacinPlacanja)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NapomenaPripreme)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NazivArtiklaUsluge)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OcekivaniDatumFakturisanja).HasColumnType("datetime");

                entity.Property(e => e.OpisRacuna)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Rabat2).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SifraArtiklaUsluge)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.SifraGrupePripremljenihRacuna)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraGrupeUsluga)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraKomercijaliste)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraOj)
                    .IsRequired()
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraPorezneGrupe)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraTeksta)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaRacuna)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.PripremljeniRacuni)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PripremljeniRacuni_dbo.PoslovniPartneri_SifraPP");

                entity.HasOne(d => d.SifraGrupePripremljenihRacunaNavigation)
                    .WithMany(p => p.PripremljeniRacuni)
                    .HasForeignKey(d => d.SifraGrupePripremljenihRacuna)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PripremljeniRacuni_dbo.GrupaPripremljenihRacuna_SifraGrupePripremljenihRacuna");

                entity.HasOne(d => d.SifraKomercijalisteNavigation)
                    .WithMany(p => p.PripremljeniRacuni)
                    .HasForeignKey(d => d.SifraKomercijaliste)
                    .HasConstraintName("FK_dbo.PripremljeniRacuni_dbo.Komercijalisti_SifraKomercijaliste");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.PripremljeniRacuni)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PripremljeniRacuni_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraPorezneGrupeNavigation)
                    .WithMany(p => p.PripremljeniRacuni)
                    .HasForeignKey(d => d.SifraPorezneGrupe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PripremljeniRacuni_dbo.PorezneGrupe_SifraPorezneGrupe");

                entity.HasOne(d => d.SifraTekstaNavigation)
                    .WithMany(p => p.PripremljeniRacuni)
                    .HasForeignKey(d => d.SifraTeksta)
                    .HasConstraintName("FK_dbo.PripremljeniRacuni_dbo.Tekstovi_SifraTeksta");
            });

            modelBuilder.Entity<Prodavaci>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK_dbo.Prodavaci");

                entity.Property(e => e.UserName).HasMaxLength(20);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NaslovIspredImena)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UvidUnezatvoreneRacuneOstalihProdavaca).HasColumnName("UvidUNezatvoreneRacuneOstalihProdavaca");

                entity.Property(e => e.UvidUnezatvoreneRacunePrethodnogDana).HasColumnName("UvidUNezatvoreneRacunePrethodnogDana");
            });

            modelBuilder.Entity<Proizvodjaci>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Proizvodjaci");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PrometDobavljaca>(entity =>
            {
                entity.HasKey(e => new { e.BrojNaloga, e.Id })
                    .HasName("PK_dbo.PrometDobavljaca");

                entity.HasIndex(e => e.BrojNaloga)
                    .HasName("IX_BrojNaloga");

                entity.HasIndex(e => e.DokumentSifra)
                    .HasName("IX_DokumentSifra");

                entity.HasIndex(e => e.PartnerSifra)
                    .HasName("IX_PartnerSifra");

                entity.HasIndex(e => e.SifraKategorije)
                    .HasName("IX_SifraKategorije");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.ValutaSifra)
                    .HasName("IX_ValutaSifra");

                entity.Property(e => e.BrojNaloga)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.DatumDpo)
                    .HasColumnName("DatumDPO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DokumentSifra)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosStraneValute).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisKnjizenja)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PartnerSifra)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraKategorije)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ValutaSifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.BrojNalogaNavigation)
                    .WithMany(p => p.PrometDobavljaca)
                    .HasForeignKey(d => d.BrojNaloga)
                    .HasConstraintName("FK_dbo.PrometDobavljaca_dbo.NaloziDobavljaca_BrojNaloga");

                entity.HasOne(d => d.DokumentSifraNavigation)
                    .WithMany(p => p.PrometDobavljaca)
                    .HasForeignKey(d => d.DokumentSifra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PrometDobavljaca_dbo.Dokumenti_DokumentSifra");

                entity.HasOne(d => d.PartnerSifraNavigation)
                    .WithMany(p => p.PrometDobavljaca)
                    .HasForeignKey(d => d.PartnerSifra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PrometDobavljaca_dbo.PoslovniPartneri_PartnerSifra");

                entity.HasOne(d => d.SifraKategorijeNavigation)
                    .WithMany(p => p.PrometDobavljaca)
                    .HasForeignKey(d => d.SifraKategorije)
                    .HasConstraintName("FK_dbo.PrometDobavljaca_dbo.KategorijePrometaDobavljaca_SifraKategorije");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.PrometDobavljaca)
                    .HasForeignKey(d => d.SifraOj)
                    .HasConstraintName("FK_dbo.PrometDobavljaca_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.ValutaSifraNavigation)
                    .WithMany(p => p.PrometDobavljaca)
                    .HasForeignKey(d => d.ValutaSifra)
                    .HasConstraintName("FK_dbo.PrometDobavljaca_dbo.KursnaLista_ValutaSifra");
            });

            modelBuilder.Entity<PrometGk>(entity =>
            {
                entity.HasKey(e => new { e.Broj, e.Id })
                    .HasName("PK_dbo.PrometGK");

                entity.ToTable("PrometGK");

                entity.HasIndex(e => e.Broj)
                    .HasName("IX_Broj");

                entity.HasIndex(e => e.CashFlowId)
                    .HasName("IX_CashFlowId");

                entity.HasIndex(e => e.Konto)
                    .HasName("IX_Konto");

                entity.HasIndex(e => e.OrganizacionaJedinicaId)
                    .HasName("IX_OrganizacionaJedinicaId");

                entity.Property(e => e.Broj)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CashFlowId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Konto)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Strana)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.BrojNavigation)
                    .WithMany(p => p.PrometGk)
                    .HasForeignKey(d => d.Broj)
                    .HasConstraintName("FK_dbo.PrometGK_dbo.NaloziGK_Broj");

                entity.HasOne(d => d.CashFlow)
                    .WithMany(p => p.PrometGk)
                    .HasForeignKey(d => d.CashFlowId)
                    .HasConstraintName("FK_dbo.PrometGK_dbo.CashFlowItems_CashFlowId");

                entity.HasOne(d => d.KontoNavigation)
                    .WithMany(p => p.PrometGk)
                    .HasForeignKey(d => d.Konto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PrometGK_dbo.AnalitickaKonta_Konto");

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.PrometGk)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PrometGK_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");
            });

            modelBuilder.Entity<PrometKupca>(entity =>
            {
                entity.HasKey(e => new { e.BrojNaloga, e.Id })
                    .HasName("PK_dbo.PrometKupca");

                entity.HasIndex(e => e.BrojNaloga)
                    .HasName("IX_BrojNaloga");

                entity.HasIndex(e => e.DokumentSifra)
                    .HasName("IX_DokumentSifra");

                entity.HasIndex(e => e.KomercijalistaSifra)
                    .HasName("IX_KomercijalistaSifra");

                entity.HasIndex(e => e.OrganizacionaJedinicaSifra)
                    .HasName("IX_OrganizacionaJedinicaSifra");

                entity.HasIndex(e => e.PartnerSifra)
                    .HasName("IX_PartnerSifra");

                entity.HasIndex(e => e.ValutaSifra)
                    .HasName("IX_ValutaSifra");

                entity.Property(e => e.BrojNaloga)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DatumDokumenta).HasColumnType("datetime");

                entity.Property(e => e.DatumDpo)
                    .HasColumnName("DatumDPO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DokumentSifra)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosStraneValute).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KomercijalistaSifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisKnjizenja)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrganizacionaJedinicaSifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PartnerSifra)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SumnjivoIspornoPotrazivanje).HasColumnName("SumnjivoISpornoPotrazivanje");

                entity.Property(e => e.ValutaSifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.BrojNalogaNavigation)
                    .WithMany(p => p.PrometKupca)
                    .HasForeignKey(d => d.BrojNaloga)
                    .HasConstraintName("FK_dbo.PrometKupca_dbo.NaloziKupca_BrojNaloga");

                entity.HasOne(d => d.DokumentSifraNavigation)
                    .WithMany(p => p.PrometKupca)
                    .HasForeignKey(d => d.DokumentSifra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PrometKupca_dbo.Dokumenti_DokumentSifra");

                entity.HasOne(d => d.KomercijalistaSifraNavigation)
                    .WithMany(p => p.PrometKupca)
                    .HasForeignKey(d => d.KomercijalistaSifra)
                    .HasConstraintName("FK_dbo.PrometKupca_dbo.Komercijalisti_KomercijalistaSifra");

                entity.HasOne(d => d.OrganizacionaJedinicaSifraNavigation)
                    .WithMany(p => p.PrometKupca)
                    .HasForeignKey(d => d.OrganizacionaJedinicaSifra)
                    .HasConstraintName("FK_dbo.PrometKupca_dbo.OrganizacioneJedinice_OrganizacionaJedinicaSifra");

                entity.HasOne(d => d.PartnerSifraNavigation)
                    .WithMany(p => p.PrometKupca)
                    .HasForeignKey(d => d.PartnerSifra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PrometKupca_dbo.PoslovniPartneri_PartnerSifra");

                entity.HasOne(d => d.ValutaSifraNavigation)
                    .WithMany(p => p.PrometKupca)
                    .HasForeignKey(d => d.ValutaSifra)
                    .HasConstraintName("FK_dbo.PrometKupca_dbo.KursnaLista_ValutaSifra");
            });

            modelBuilder.Entity<PrometPotrosaca>(entity =>
            {
                entity.HasKey(e => new { e.SifraPotrosaca, e.Id })
                    .HasName("PK_dbo.PrometPotrosaca");

                entity.HasIndex(e => e.SifraPotrosaca)
                    .HasName("IX_SifraPotrosaca");

                entity.Property(e => e.SifraPotrosaca)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VrstaPrometa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraPotrosacaNavigation)
                    .WithMany(p => p.PrometPotrosaca)
                    .HasForeignKey(d => d.SifraPotrosaca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PrometPotrosaca_dbo.Potrosaci_SifraPotrosaca");
            });

            modelBuilder.Entity<PrometiBlagajne>(entity =>
            {
                entity.HasKey(e => new { e.BlagajnaId, e.Id })
                    .HasName("PK_dbo.PrometiBlagajne");

                entity.HasIndex(e => e.CashFlowItemId)
                    .HasName("IX_CashFlowItemId");

                entity.HasIndex(e => e.SifraKonta)
                    .HasName("IX_SifraKonta");

                entity.HasIndex(e => e.SifraPoslovnogPartnera)
                    .HasName("IX_SifraPoslovnogPartnera");

                entity.HasIndex(e => new { e.BlagajnaId, e.Broj })
                    .HasName("IX_BlagajnaId_Broj");

                entity.Property(e => e.BlagajnaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Broj)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CashFlowItemId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.IznosKnjizenja).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisKnjizenja)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SifraKonta)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.SifraPoslovnogPartnera)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.HasOne(d => d.CashFlowItem)
                    .WithMany(p => p.PrometiBlagajne)
                    .HasForeignKey(d => d.CashFlowItemId)
                    .HasConstraintName("FK_dbo.PrometiBlagajne_dbo.CashFlowItems_CashFlowItemId");

                entity.HasOne(d => d.SifraKontaNavigation)
                    .WithMany(p => p.PrometiBlagajne)
                    .HasForeignKey(d => d.SifraKonta)
                    .HasConstraintName("FK_dbo.PrometiBlagajne_dbo.AnalitickaKonta_SifraKonta");

                entity.HasOne(d => d.SifraPoslovnogPartneraNavigation)
                    .WithMany(p => p.PrometiBlagajne)
                    .HasForeignKey(d => d.SifraPoslovnogPartnera)
                    .HasConstraintName("FK_dbo.PrometiBlagajne_dbo.PoslovniPartneri_SifraPoslovnogPartnera");

                entity.HasOne(d => d.B)
                    .WithMany(p => p.PrometiBlagajne)
                    .HasForeignKey(d => new { d.BlagajnaId, d.Broj })
                    .HasConstraintName("FK_dbo.PrometiBlagajne_dbo.NaloziBlagajne_BlagajnaId_Broj");
            });

            modelBuilder.Entity<RacuniVp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.VrstaRacuna, e.BrojRacuna })
                    .HasName("PK_dbo.RacuniVP");

                entity.ToTable("RacuniVP");

                entity.HasIndex(e => e.BrojOtpremniceVeleprodajeUtoku)
                    .HasName("IX_BrojOtpremniceVeleprodajeUToku");

                entity.HasIndex(e => e.BrojRadnogNalogaMp)
                    .HasName("IX_BrojRadnogNalogaMP");

                entity.HasIndex(e => e.BrojRadnogNalogaProizvodnje)
                    .HasName("IX_BrojRadnogNalogaProizvodnje");

                entity.HasIndex(e => e.KupacId)
                    .HasName("IX_KupacId");

                entity.HasIndex(e => e.SifraKomercijaliste)
                    .HasName("IX_SifraKomercijaliste");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.SifraTeksta)
                    .HasName("IX_SifraTeksta");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaRacuna)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.BrojRacuna)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojNarudzbe).HasMaxLength(50);

                entity.Property(e => e.BrojOtpremnice).HasMaxLength(50);

                entity.Property(e => e.BrojOtpremniceVeleprodajeUtoku)
                    .HasColumnName("BrojOtpremniceVeleprodajeUToku")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.BrojRadnogNalogaMp)
                    .HasColumnName("BrojRadnogNalogaMP")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.BrojRadnogNalogaProizvodnje)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.DatumDpo)
                    .HasColumnName("DatumDPO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatumNarudzbe).HasColumnType("datetime");

                entity.Property(e => e.DatumOtpremnice).HasColumnType("datetime");

                entity.Property(e => e.DatumRacuna).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.KupacId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinPlacanja)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OpisRacuna).HasMaxLength(200);

                entity.Property(e => e.PripremljeniRacunId)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraKomercijaliste)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraTeksta)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VezniDokument).HasMaxLength(50);

                entity.HasOne(d => d.BrojOtpremniceVeleprodajeUtokuNavigation)
                    .WithMany(p => p.RacuniVp)
                    .HasForeignKey(d => d.BrojOtpremniceVeleprodajeUtoku)
                    .HasConstraintName("FK_dbo.RacuniVP_dbo.OtpremniceVeleprodajeUToku_BrojOtpremniceVeleprodajeUToku");

                entity.HasOne(d => d.BrojRadnogNalogaMpNavigation)
                    .WithMany(p => p.RacuniVp)
                    .HasForeignKey(d => d.BrojRadnogNalogaMp)
                    .HasConstraintName("FK_dbo.RacuniVP_dbo.RadniNalogMP_BrojRadnogNalogaMP");

                entity.HasOne(d => d.BrojRadnogNalogaProizvodnjeNavigation)
                    .WithMany(p => p.RacuniVp)
                    .HasForeignKey(d => d.BrojRadnogNalogaProizvodnje)
                    .HasConstraintName("FK_dbo.RacuniVP_dbo.RadniNalogProizvodnje_BrojRadnogNalogaProizvodnje");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.RacuniVp)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RacuniVP_dbo.PoslovniPartneri_SifraPP");

                entity.HasOne(d => d.SifraKomercijalisteNavigation)
                    .WithMany(p => p.RacuniVp)
                    .HasForeignKey(d => d.SifraKomercijaliste)
                    .HasConstraintName("FK_dbo.RacuniVP_dbo.Komercijalisti_SifraKomercijaliste");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.RacuniVp)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RacuniVP_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraTekstaNavigation)
                    .WithMany(p => p.RacuniVp)
                    .HasForeignKey(d => d.SifraTeksta)
                    .HasConstraintName("FK_dbo.RacuniVP_dbo.Tekstovi_SifraTeksta");
            });

            modelBuilder.Entity<RadniNalogMp>(entity =>
            {
                entity.HasKey(e => e.Broj)
                    .HasName("PK_dbo.RadniNalogMP");

                entity.ToTable("RadniNalogMP");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.SifraPp)
                    .HasName("IX_SifraPP");

                entity.HasIndex(e => e.SifraVeleprodajneOj)
                    .HasName("IX_SifraVeleprodajneOJ");

                entity.Property(e => e.Broj)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CijenaUsluge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.DatumZavrsetkaRadova).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NalogJeOtvorio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NalogJeZatvorio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OpisIzvrsenihRadova)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OpisPotrebnihRadova)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OpisUsluge).HasMaxLength(100);

                entity.Property(e => e.OznakaUredaja)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SifraOj)
                    .IsRequired()
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraPp)
                    .IsRequired()
                    .HasColumnName("SifraPP")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraUsluge)
                    .HasColumnName("SIfraUsluge")
                    .HasMaxLength(6);

                entity.Property(e => e.SifraVeleprodajneOj)
                    .HasColumnName("SifraVeleprodajneOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.TipUredaja)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ZaduzenoLice)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.RadniNalogMpSifraOjNavigation)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RadniNalogMP_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraPpNavigation)
                    .WithMany(p => p.RadniNalogMp)
                    .HasForeignKey(d => d.SifraPp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RadniNalogMP_dbo.PoslovniPartneri_PoslovniPartneri_Sifra");

                entity.HasOne(d => d.SifraVeleprodajneOjNavigation)
                    .WithMany(p => p.RadniNalogMpSifraVeleprodajneOjNavigation)
                    .HasForeignKey(d => d.SifraVeleprodajneOj)
                    .HasConstraintName("FK_dbo.RadniNalogMP_dbo.OrganizacioneJedinice_SifraVeleprodajneOJ");
            });

            modelBuilder.Entity<RadniNalogProizvodnje>(entity =>
            {
                entity.HasKey(e => e.Broj)
                    .HasName("PK_dbo.RadniNalogProizvodnje");

                entity.HasIndex(e => e.SifraKupca)
                    .HasName("IX_SifraKupca");

                entity.HasIndex(e => e.SkladisteId)
                    .HasName("IX_SkladisteId");

                entity.HasIndex(e => e.TrgovackoSkladiste)
                    .HasName("IX_TrgovackoSkladiste");

                entity.Property(e => e.Broj)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CijenaUsluge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.DatumZavrsetkaRadova).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisPotrebnihRadova)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OpisUsluge).HasMaxLength(100);

                entity.Property(e => e.ProcenatOpcihTroskovaProizvodnje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SifraKupca)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SifraUsluge)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.SkladisteId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.TrgovackoSkladiste)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraKupcaNavigation)
                    .WithMany(p => p.RadniNalogProizvodnje)
                    .HasForeignKey(d => d.SifraKupca)
                    .HasConstraintName("FK_dbo.RadniNalogProizvodnje_dbo.PoslovniPartneri_SifraKupca");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.RadniNalogProizvodnjeSkladiste)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RadniNalogProizvodnje_dbo.OrganizacioneJedinice_SkladisteId");

                entity.HasOne(d => d.TrgovackoSkladisteNavigation)
                    .WithMany(p => p.RadniNalogProizvodnjeTrgovackoSkladisteNavigation)
                    .HasForeignKey(d => d.TrgovackoSkladiste)
                    .HasConstraintName("FK_dbo.RadniNalogProizvodnje_dbo.OrganizacioneJedinice_TrgovackoSkladiste");
            });

            modelBuilder.Entity<Regije>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Regije");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Entitet)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Repromaterijal>(entity =>
            {
                entity.HasIndex(e => e.DobavljacId)
                    .HasName("IX_DobavljacId");

                entity.HasIndex(e => e.GrupaArtikalaId)
                    .HasName("IX_GrupaArtikalaId");

                entity.HasIndex(e => e.KlasifikacijaId)
                    .HasName("IX_KlasifikacijaId");

                entity.HasIndex(e => e.PoreznaGrupaId)
                    .HasName("IX_PoreznaGrupaId");

                entity.HasIndex(e => e.ProizvodjacId)
                    .HasName("IX_ProizvodjacId");

                entity.HasIndex(e => e.ZemljaPorijeklaId)
                    .HasName("IX_ZemljaPorijeklaId");

                entity.Property(e => e.RepromaterijalId)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.CarinskaTarifa).HasMaxLength(10);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DobavljacId)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.GrupaArtikalaId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.JedinicaMjere)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.KataloskiBroj).HasMaxLength(16);

                entity.Property(e => e.KlasifikacijaId)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.MaksimalnaZaliha).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinimalnaZaliha).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Opis).HasMaxLength(2000);

                entity.Property(e => e.OpisPakovanja).HasMaxLength(20);

                entity.Property(e => e.PoreznaGrupaId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PostotakDozvoljenogOtpisa).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.ProizvodjacId)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Tezina).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZemljaPorijeklaId)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.HasOne(d => d.Dobavljac)
                    .WithMany(p => p.Repromaterijal)
                    .HasForeignKey(d => d.DobavljacId)
                    .HasConstraintName("FK_dbo.Repromaterijal_dbo.PoslovniPartneri_DobavljacId");

                entity.HasOne(d => d.GrupaArtikala)
                    .WithMany(p => p.Repromaterijal)
                    .HasForeignKey(d => d.GrupaArtikalaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Repromaterijal_dbo.GrupeArtikala_GrupaArtikalaId");

                entity.HasOne(d => d.Klasifikacija)
                    .WithMany(p => p.Repromaterijal)
                    .HasForeignKey(d => d.KlasifikacijaId)
                    .HasConstraintName("FK_dbo.Repromaterijal_dbo.Klasifikacije_KlasifikacijaId");

                entity.HasOne(d => d.PoreznaGrupa)
                    .WithMany(p => p.Repromaterijal)
                    .HasForeignKey(d => d.PoreznaGrupaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Repromaterijal_dbo.PorezneGrupe_PoreznaGrupaId");

                entity.HasOne(d => d.Proizvodjac)
                    .WithMany(p => p.Repromaterijal)
                    .HasForeignKey(d => d.ProizvodjacId)
                    .HasConstraintName("FK_dbo.Repromaterijal_dbo.Proizvodjaci_ProizvodjacId");

                entity.HasOne(d => d.ZemljaPorijekla)
                    .WithMany(p => p.Repromaterijal)
                    .HasForeignKey(d => d.ZemljaPorijeklaId)
                    .HasConstraintName("FK_dbo.Repromaterijal_dbo.Drzave_ZemljaPorijeklaId");
            });

            modelBuilder.Entity<ShemaZatvaranjaKlasa>(entity =>
            {
                entity.HasIndex(e => e.Konto)
                    .HasName("IX_Konto");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Klasa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Konto)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Strana)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.KontoNavigation)
                    .WithMany(p => p.ShemaZatvaranjaKlasa)
                    .HasForeignKey(d => d.Konto)
                    .HasConstraintName("FK_dbo.ShemaZatvaranjaKlasa_dbo.AnalitickaKonta_Konto");
            });

            modelBuilder.Entity<SintetickaKonta>(entity =>
            {
                entity.HasKey(e => e.Konto)
                    .HasName("PK_dbo.SintetickaKonta");

                entity.Property(e => e.Konto)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Aop)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Skladistari>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Skladistari");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ImePrezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Napomena).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(20);
            });

            modelBuilder.Entity<Sms>(entity =>
            {
                entity.ToTable("SMS");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KorisnikImePrezime).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Posiljalac).HasMaxLength(12);

                entity.Property(e => e.Primalac).HasMaxLength(12);

                entity.Property(e => e.PrimalacImePrezime).HasMaxLength(100);

                entity.Property(e => e.Tekst)
                    .IsRequired()
                    .HasMaxLength(800);

                entity.Property(e => e.Tip)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StavkaObrascaSl2>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.RedniBroj, e.Id })
                    .HasName("PK_dbo.StavkaObrascaSL2");

                entity.ToTable("StavkaObrascaSL2");

                entity.HasIndex(e => new { e.SifraOj, e.RedniBroj })
                    .HasName("IX_SifraOJ_RedniBroj");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RedniBroj)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DatumRacuna).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IznosBezPdv)
                    .HasColumnName("IznosBezPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosPdv)
                    .HasColumnName("IznosPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ObrazacSl2)
                    .WithMany(p => p.StavkaObrascaSl2)
                    .HasForeignKey(d => new { d.SifraOj, d.RedniBroj })
                    .HasConstraintName("FK_dbo.StavkaObrascaSL2_dbo.ObrazacSL2_SifraOJ_RedniBroj");
            });

            modelBuilder.Entity<StavkeBilansaStanja>(entity =>
            {
                entity.HasKey(e => e.Aop)
                    .HasName("PK_dbo.StavkeBilansaStanja");

                entity.Property(e => e.Aop)
                    .HasColumnName("AOP")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.FiksniIznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IznosProslaGodina).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinObracuna)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<StavkeBilansaUspjeha>(entity =>
            {
                entity.HasKey(e => e.Aop)
                    .HasName("PK_dbo.StavkeBilansaUspjeha");

                entity.Property(e => e.Aop)
                    .HasColumnName("AOP")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.FiksniIznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IznosProslaGodina).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinObracuna)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<StavkeKalkulacijeRepromaterijala>(entity =>
            {
                entity.HasKey(e => new { e.SkladisteId, e.BrojKalkulacije, e.Id })
                    .HasName("PK_dbo.StavkeKalkulacijeRepromaterijala");

                entity.HasIndex(e => e.RepromaterijalId)
                    .HasName("IX_RepromaterijalId");

                entity.HasIndex(e => new { e.SkladisteId, e.BrojKalkulacije })
                    .HasName("IX_SkladisteId_BrojKalkulacije");

                entity.Property(e => e.SkladisteId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.BrojKalkulacije)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Akciza).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Rabat2).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RepromaterijalId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.ZavisniTrosak).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Repromaterijal)
                    .WithMany(p => p.StavkeKalkulacijeRepromaterijala)
                    .HasForeignKey(d => d.RepromaterijalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeKalkulacijeRepromaterijala_dbo.Repromaterijal_RepromaterijalId");

                entity.HasOne(d => d.Skladiste)
                    .WithMany(p => p.StavkeKalkulacijeRepromaterijala)
                    .HasForeignKey(d => d.SkladisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeKalkulacijeRepromaterijala_dbo.OrganizacioneJedinice_SkladisteId");

                entity.HasOne(d => d.KalkulacijeRepromaterijala)
                    .WithMany(p => p.StavkeKalkulacijeRepromaterijala)
                    .HasForeignKey(d => new { d.SkladisteId, d.BrojKalkulacije })
                    .HasConstraintName("FK_dbo.StavkeKalkulacijeRepromaterijala_dbo.KalkulacijeRepromaterijala_SkladisteId_BrojKalkulacije");
            });

            modelBuilder.Entity<StavkeKalkulacijeVp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.BrojKalkulacije, e.Id })
                    .HasName("PK_dbo.StavkeKalkulacijeVP");

                entity.ToTable("StavkeKalkulacijeVP");

                entity.HasIndex(e => e.SifraArtikla)
                    .HasName("IX_SifraArtikla");

                entity.HasIndex(e => new { e.SifraOj, e.BrojKalkulacije })
                    .HasName("IX_SifraOJ_BrojKalkulacije");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.BrojKalkulacije)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Akciza).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BrojKontrolePrveSerije).HasMaxLength(15);

                entity.Property(e => e.BrojKontroleSvakeSerije).HasMaxLength(15);

                entity.Property(e => e.BrojSerije).HasMaxLength(30);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Marza).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Rabat2).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RokTrajanja).HasColumnType("datetime");

                entity.Property(e => e.SifraArtikla)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.ZavisniTrosak).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.SifraArtiklaNavigation)
                    .WithMany(p => p.StavkeKalkulacijeVp)
                    .HasForeignKey(d => d.SifraArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeKalkulacijeVP_dbo.Artikli_SifraArtikla");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.StavkeKalkulacijeVp)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeKalkulacijeVP_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.KalkulacijeVp)
                    .WithMany(p => p.StavkeKalkulacijeVp)
                    .HasForeignKey(d => new { d.SifraOj, d.BrojKalkulacije })
                    .HasConstraintName("FK_dbo.StavkeKalkulacijeVP_dbo.KalkulacijeVP_SifraOJ_BrojKalkulacije");
            });

            modelBuilder.Entity<StavkeKnjiznihObavijesti>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.VrstaKnjizneObavijesti, e.BrojKnjizneObavijesti, e.Id })
                    .HasName("PK_dbo.StavkeKnjiznihObavijesti");

                entity.HasIndex(e => e.SifraGrupeUsluga)
                    .HasName("IX_SifraGrupeUsluga");

                entity.HasIndex(e => e.SifraPorezneGrupe)
                    .HasName("IX_SifraPorezneGrupe");

                entity.HasIndex(e => new { e.SifraOj, e.VrstaKnjizneObavijesti, e.BrojKnjizneObavijesti })
                    .HasName("IX_SifraOJ_VrstaKnjizneObavijesti_BrojKnjizneObavijesti");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaKnjizneObavijesti)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.BrojKnjizneObavijesti)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.JedinicaMjere)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.NacinObracunaPdva)
                    .IsRequired()
                    .HasColumnName("NacinObracunaPDVa")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NazivArtikla)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SifraArtikla)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.SifraGrupeUsluga)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraPorezneGrupe)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraGrupeUslugaNavigation)
                    .WithMany(p => p.StavkeKnjiznihObavijesti)
                    .HasForeignKey(d => d.SifraGrupeUsluga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeKnjiznihObavijesti_dbo.GrupeUsluga_SifraGrupeUsluga");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.StavkeKnjiznihObavijesti)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeKnjiznihObavijesti_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraPorezneGrupeNavigation)
                    .WithMany(p => p.StavkeKnjiznihObavijesti)
                    .HasForeignKey(d => d.SifraPorezneGrupe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeKnjiznihObavijesti_dbo.PorezneGrupe_SifraPorezneGrupe");

                entity.HasOne(d => d.KnjizneObavijesti)
                    .WithMany(p => p.StavkeKnjiznihObavijesti)
                    .HasForeignKey(d => new { d.SifraOj, d.VrstaKnjizneObavijesti, d.BrojKnjizneObavijesti })
                    .HasConstraintName("FK_dbo.StavkeKnjiznihObavijesti_dbo.KnjizneObavijesti_SifraOJ_VrstaKnjizneObavijesti_BrojKnjizneObavijesti");
            });

            modelBuilder.Entity<StavkeNaAkcijiMp>(entity =>
            {
                entity.HasKey(e => new { e.RedniBrojAkcije, e.Id })
                    .HasName("PK_dbo.StavkeNaAkcijiMP");

                entity.ToTable("StavkeNaAkcijiMP");

                entity.HasIndex(e => e.ArtiklId)
                    .HasName("IX_ArtiklId");

                entity.HasIndex(e => e.RedniBrojAkcije)
                    .HasName("IX_RedniBrojAkcije");

                entity.Property(e => e.RedniBrojAkcije).HasMaxLength(6);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ArtiklId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostotakPopusta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdajnaCijena).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Artikl)
                    .WithMany(p => p.StavkeNaAkcijiMp)
                    .HasForeignKey(d => d.ArtiklId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeNaAkcijiMP_dbo.Artikli_ArtiklId");

                entity.HasOne(d => d.RedniBrojAkcijeNavigation)
                    .WithMany(p => p.StavkeNaAkcijiMp)
                    .HasForeignKey(d => d.RedniBrojAkcije)
                    .HasConstraintName("FK_dbo.StavkeNaAkcijiMP_dbo.DokumentiAkcijaMP_RedniBrojAkcije");
            });

            modelBuilder.Entity<StavkeNalogaKompenzacije>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.SifraKompenzacije, e.Id })
                    .HasName("PK_dbo.StavkeNalogaKompenzacije");

                entity.HasIndex(e => new { e.SifraOj, e.SifraKompenzacije })
                    .HasName("IX_SifraOJ_SifraKompenzacije");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SifraKompenzacije).HasMaxLength(6);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Sifra)
                    .WithMany(p => p.StavkeNalogaKompenzacije)
                    .HasForeignKey(d => new { d.SifraOj, d.SifraKompenzacije })
                    .HasConstraintName("FK_dbo.StavkeNalogaKompenzacije_dbo.NaloziKompenzacije_SifraOJ_SifraKompenzacije");
            });

            modelBuilder.Entity<StavkeNarudzbeniceDobavljacu>(entity =>
            {
                entity.HasKey(e => new { e.OrganizacionaJedinicaId, e.Broj, e.Id })
                    .HasName("PK_dbo.StavkeNarudzbeniceDobavljacu");

                entity.HasIndex(e => e.PoreznaGrupaId)
                    .HasName("IX_PoreznaGrupaId");

                entity.HasIndex(e => new { e.OrganizacionaJedinicaId, e.Broj })
                    .HasName("IX_OrganizacionaJedinicaId_Broj");

                entity.Property(e => e.OrganizacionaJedinicaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Broj)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ArtiklId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.BarCode).HasMaxLength(13);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.JedinicaMjere)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.KataloskiBroj).HasMaxLength(16);

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinObracunaPdva)
                    .IsRequired()
                    .HasColumnName("NacinObracunaPDVa")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NazivArtikla)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PoreznaGrupaId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaStavkeNarudzbenice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.OrganizacionaJedinica)
                    .WithMany(p => p.StavkeNarudzbeniceDobavljacu)
                    .HasForeignKey(d => d.OrganizacionaJedinicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeNarudzbeniceDobavljacu_dbo.OrganizacioneJedinice_OrganizacionaJedinicaId");

                entity.HasOne(d => d.PoreznaGrupa)
                    .WithMany(p => p.StavkeNarudzbeniceDobavljacu)
                    .HasForeignKey(d => d.PoreznaGrupaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeNarudzbeniceDobavljacu_dbo.PorezneGrupe_PoreznaGrupaId");

                entity.HasOne(d => d.NarudzbeniceDobavljacu)
                    .WithMany(p => p.StavkeNarudzbeniceDobavljacu)
                    .HasForeignKey(d => new { d.OrganizacionaJedinicaId, d.Broj })
                    .HasConstraintName("FK_dbo.StavkeNarudzbeniceDobavljacu_dbo.NarudzbeniceDobavljacu_OrganizacionaJedinicaId_Broj");
            });

            modelBuilder.Entity<StavkeNarudzbeniceKupca>(entity =>
            {
                entity.HasKey(e => new { e.KomercijalistaId, e.BrojNarudzbenice, e.Id })
                    .HasName("PK_dbo.StavkeNarudzbeniceKupca");

                entity.HasIndex(e => e.ArtiklId)
                    .HasName("IX_ArtiklId");

                entity.HasIndex(e => e.KomercijalistaSifra)
                    .HasName("IX_Komercijalista_Sifra");

                entity.HasIndex(e => new { e.KomercijalistaId, e.BrojNarudzbenice })
                    .HasName("IX_KomercijalistaId_BrojNarudzbenice");

                entity.Property(e => e.KomercijalistaId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.BrojNarudzbenice)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ArtiklId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.BrojSerije).HasMaxLength(30);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.KolicinaIsporuceno).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.KolicinaNaruceno).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.KomercijalistaSifra)
                    .HasColumnName("Komercijalista_Sifra")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpisStavke).HasMaxLength(100);

                entity.Property(e => e.RokTrajanja).HasColumnType("datetime");

                entity.Property(e => e.VeleprodajnaCijena).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Artikl)
                    .WithMany(p => p.StavkeNarudzbeniceKupca)
                    .HasForeignKey(d => d.ArtiklId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeNarudzbeniceKupca_dbo.Artikli_ArtiklId");

                entity.HasOne(d => d.KomercijalistaSifraNavigation)
                    .WithMany(p => p.StavkeNarudzbeniceKupca)
                    .HasForeignKey(d => d.KomercijalistaSifra)
                    .HasConstraintName("FK_dbo.StavkeNarudzbeniceKupca_dbo.Komercijalisti_Komercijalista_Sifra");

                entity.HasOne(d => d.NarudzbeniceKupca)
                    .WithMany(p => p.StavkeNarudzbeniceKupca)
                    .HasForeignKey(d => new { d.KomercijalistaId, d.BrojNarudzbenice })
                    .HasConstraintName("FK_dbo.StavkeNarudzbeniceKupca_dbo.NarudzbeniceKupca_KomercijalistaId_BrojNarudzbenice");
            });

            modelBuilder.Entity<StavkeNormativa>(entity =>
            {
                entity.HasKey(e => new { e.GotovProizvodId, e.Id })
                    .HasName("PK_dbo.StavkeNormativa");

                entity.HasIndex(e => new { e.GotovProizvodId, e.RepromaterijalId })
                    .HasName("IX_GotovProizvodId_RepromaterijalId")
                    .IsUnique();

                entity.Property(e => e.GotovProizvodId)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis).HasMaxLength(100);

                entity.Property(e => e.RepromaterijalId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.SkartPostotak).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.GotovProizvod)
                    .WithMany(p => p.StavkeNormativa)
                    .HasForeignKey(d => d.GotovProizvodId)
                    .HasConstraintName("FK_dbo.StavkeNormativa_dbo.Normativi_GotovProizvodId");

                entity.HasOne(d => d.Repromaterijal)
                    .WithMany(p => p.StavkeNormativa)
                    .HasForeignKey(d => d.RepromaterijalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeNormativa_dbo.Repromaterijal_RepromaterijalId");
            });

            modelBuilder.Entity<StavkePrometaMp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOrganizacioneJedinice, e.VrstaPrometa, e.BrojDokumenta, e.Id })
                    .HasName("PK_dbo.StavkePrometaMP");

                entity.ToTable("StavkePrometaMP");

                entity.HasIndex(e => e.SifraArtikla)
                    .HasName("IX_SifraArtikla");

                entity.HasIndex(e => new { e.SifraOrganizacioneJedinice, e.VrstaPrometa, e.BrojDokumenta })
                    .HasName("IX_SifraOrganizacioneJedinice_VrstaPrometa_BrojDokumenta");

                entity.Property(e => e.SifraOrganizacioneJedinice)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaPrometa)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.BrojDokumenta)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MaloprodajnaCijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OpisPrometa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostotakPopusta).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PrethodnaMaloprodajnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SifraArtikla)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraArtiklaNavigation)
                    .WithMany(p => p.StavkePrometaMp)
                    .HasForeignKey(d => d.SifraArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkePrometaMP_dbo.Artikli_SifraArtikla");

                entity.HasOne(d => d.SifraOrganizacioneJediniceNavigation)
                    .WithMany(p => p.StavkePrometaMp)
                    .HasForeignKey(d => d.SifraOrganizacioneJedinice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkePrometaMP_dbo.OrganizacioneJedinice_SifraOrganizacioneJedinice");

                entity.HasOne(d => d.DokumentiPrometaMp)
                    .WithMany(p => p.StavkePrometaMp)
                    .HasForeignKey(d => new { d.SifraOrganizacioneJedinice, d.VrstaPrometa, d.BrojDokumenta })
                    .HasConstraintName("FK_dbo.StavkePrometaMP_dbo.DokumentiPrometaMP_SifraOrganizacioneJedinice_VrstaPrometa_BrojDokumenta");
            });

            modelBuilder.Entity<StavkePrometaRepromaterijala>(entity =>
            {
                entity.HasKey(e => new { e.SkladisteId, e.VrstaPrometaId, e.BrojDokumenta, e.Id })
                    .HasName("PK_dbo.StavkePrometaRepromaterijala");

                entity.HasIndex(e => e.RepromaterijalId)
                    .HasName("IX_RepromaterijalId");

                entity.HasIndex(e => new { e.SkladisteId, e.VrstaPrometaId, e.BrojDokumenta })
                    .HasName("IX_SkladisteId_VrstaPrometaId_BrojDokumenta");

                entity.Property(e => e.SkladisteId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaPrometaId)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.BrojDokumenta)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RepromaterijalId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.HasOne(d => d.Repromaterijal)
                    .WithMany(p => p.StavkePrometaRepromaterijala)
                    .HasForeignKey(d => d.RepromaterijalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkePrometaRepromaterijala_dbo.Repromaterijal_RepromaterijalId");

                entity.HasOne(d => d.DokumentiPrometaRepromaterijala)
                    .WithMany(p => p.StavkePrometaRepromaterijala)
                    .HasForeignKey(d => new { d.SkladisteId, d.VrstaPrometaId, d.BrojDokumenta })
                    .HasConstraintName("FK_dbo.StavkePrometaRepromaterijala_dbo.DokumentiPrometaRepromaterijala_SkladisteId_VrstaPrometaId_BrojDokumenta");
            });

            modelBuilder.Entity<StavkePrometaVp>(entity =>
            {
                entity.HasKey(e => new { e.SkladisteId, e.VrstaPrometaId, e.BrojDokumenta, e.Id })
                    .HasName("PK_dbo.StavkePrometaVP");

                entity.ToTable("StavkePrometaVP");

                entity.HasIndex(e => e.ArtiklId)
                    .HasName("IX_ArtiklId");

                entity.HasIndex(e => new { e.SkladisteId, e.VrstaPrometaId, e.BrojDokumenta })
                    .HasName("IX_SkladisteId_VrstaPrometaId_BrojDokumenta");

                entity.Property(e => e.SkladisteId)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaPrometaId)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.BrojDokumenta)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ArtiklId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.BrojKontrolePrveSerije).HasMaxLength(20);

                entity.Property(e => e.BrojKontroleSvakeSerije).HasMaxLength(20);

                entity.Property(e => e.BrojSerije).HasMaxLength(30);

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OpisPrometa)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RokTrajanja).HasColumnType("datetime");

                entity.Property(e => e.StaraVeleprodajnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.VeleprodajnaCijena).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Artikl)
                    .WithMany(p => p.StavkePrometaVp)
                    .HasForeignKey(d => d.ArtiklId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkePrometaVP_dbo.Artikli_ArtiklId");

                entity.HasOne(d => d.DokumentiPrometaVp)
                    .WithMany(p => p.StavkePrometaVp)
                    .HasForeignKey(d => new { d.SkladisteId, d.VrstaPrometaId, d.BrojDokumenta })
                    .HasConstraintName("FK_dbo.StavkePrometaVP_dbo.DokumentiPrometaVP_SkladisteId_VrstaPrometaId_BrojDokumenta");
            });

            modelBuilder.Entity<StavkeRacunaVp>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.VrstaRacuna, e.BrojRacuna, e.Id })
                    .HasName("PK_dbo.StavkeRacunaVP");

                entity.ToTable("StavkeRacunaVP");

                entity.HasIndex(e => e.SifraGrupeUsluga)
                    .HasName("IX_SifraGrupeUsluga");

                entity.HasIndex(e => e.SifraOjstavkeOtpremnice)
                    .HasName("IX_SifraOJStavkeOtpremnice");

                entity.HasIndex(e => e.SifraPorezneGrupe)
                    .HasName("IX_SifraPorezneGrupe");

                entity.HasIndex(e => new { e.SifraOj, e.VrstaRacuna, e.BrojRacuna })
                    .HasName("IX_SifraOJ_VrstaRacuna_BrojRacuna");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.VrstaRacuna)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.BrojRacuna)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BarCodeArtikla).HasMaxLength(13);

                entity.Property(e => e.BrojKontrolePrveSerije).HasMaxLength(20);

                entity.Property(e => e.BrojKontroleSvakeSerije).HasMaxLength(20);

                entity.Property(e => e.BrojSerije).HasMaxLength(30);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.JedinicaMjere)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.KataloskiBrojArtikla).HasMaxLength(16);

                entity.Property(e => e.KlasifikacijaNaziv).HasMaxLength(100);

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NabavnaCijena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.NacinObracunaPdva)
                    .IsRequired()
                    .HasColumnName("NacinObracunaPDVa")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NazivArtikla)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProizvodjacNaziv).HasMaxLength(100);

                entity.Property(e => e.Rabat1).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Rabat2).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RokTrajanja).HasColumnType("datetime");

                entity.Property(e => e.SifraArtikla)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.SifraGrupeUsluga)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraOjstavkeOtpremnice)
                    .HasColumnName("SifraOJStavkeOtpremnice")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraPorezneGrupe)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraGrupeUslugaNavigation)
                    .WithMany(p => p.StavkeRacunaVp)
                    .HasForeignKey(d => d.SifraGrupeUsluga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeRacunaVP_dbo.GrupeUsluga_SifraGrupeUsluga");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.StavkeRacunaVpSifraOjNavigation)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeRacunaVP_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraOjstavkeOtpremniceNavigation)
                    .WithMany(p => p.StavkeRacunaVpSifraOjstavkeOtpremniceNavigation)
                    .HasForeignKey(d => d.SifraOjstavkeOtpremnice)
                    .HasConstraintName("FK_dbo.StavkeRacunaVP_dbo.OrganizacioneJedinice_SifraOJStavkeOtpremnice");

                entity.HasOne(d => d.SifraPorezneGrupeNavigation)
                    .WithMany(p => p.StavkeRacunaVp)
                    .HasForeignKey(d => d.SifraPorezneGrupe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeRacunaVP_dbo.PorezneGrupe_SifraPorezneGrupe");

                entity.HasOne(d => d.RacuniVp)
                    .WithMany(p => p.StavkeRacunaVp)
                    .HasForeignKey(d => new { d.SifraOj, d.VrstaRacuna, d.BrojRacuna })
                    .HasConstraintName("FK_dbo.StavkeRacunaVP_dbo.RacuniVP_SifraOJ_VrstaRacuna_BrojRacuna");
            });

            modelBuilder.Entity<StavkeUgovorenihCijena>(entity =>
            {
                entity.HasKey(e => new { e.SifraUgovoreneCijene, e.Id })
                    .HasName("PK_dbo.StavkeUgovorenihCijena");

                entity.HasIndex(e => e.ArtiklId)
                    .HasName("IX_ArtiklId");

                entity.HasIndex(e => e.SifraUgovoreneCijene)
                    .HasName("IX_SifraUgovoreneCijene");

                entity.Property(e => e.SifraUgovoreneCijene)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ArtiklId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CijenaUgovorena).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CijenaUgovorenaMaloprodaja).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PopustUgovoren).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PopustUgovorenMaloprodaja).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Artikl)
                    .WithMany(p => p.StavkeUgovorenihCijena)
                    .HasForeignKey(d => d.ArtiklId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StavkeUgovorenihCijena_dbo.Artikli_ArtiklId");

                entity.HasOne(d => d.SifraUgovoreneCijeneNavigation)
                    .WithMany(p => p.StavkeUgovorenihCijena)
                    .HasForeignKey(d => d.SifraUgovoreneCijene)
                    .HasConstraintName("FK_dbo.StavkeUgovorenihCijena_dbo.UgovoreneCijene_SifraUgovoreneCijene");
            });

            modelBuilder.Entity<StraniDrzavljani>(entity =>
            {
                entity.HasIndex(e => e.Drzava)
                    .HasName("IX_Drzava");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankovniRacun)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.BrojPutneIsprave)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Drzava)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Mjesto)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Napomena)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NazivBanke)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.DrzavaNavigation)
                    .WithMany(p => p.StraniDrzavljani)
                    .HasForeignKey(d => d.Drzava)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.StraniDrzavljani_dbo.Drzave_Drzava");
            });

            modelBuilder.Entity<Takse>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Takse");

                entity.HasIndex(e => e.KontoObaveze)
                    .HasName("IX_KontoObaveze");

                entity.HasIndex(e => e.KontoRealiziraniPdvNeobveznicima)
                    .HasName("IX_KontoRealiziraniPdvNeobveznicima");

                entity.HasIndex(e => e.KontoRealiziraniPdvObveznicima)
                    .HasName("IX_KontoRealiziraniPdvObveznicima");

                entity.HasIndex(e => e.KontoUkalkulisaneTakse)
                    .HasName("IX_KontoUkalkulisaneTakse");

                entity.HasIndex(e => e.SifraArtikla)
                    .HasName("IX_SifraArtikla");

                entity.HasIndex(e => e.SifraGrupeArtikala)
                    .HasName("IX_SifraGrupeArtikala");

                entity.HasIndex(e => e.SifraTeksta)
                    .HasName("IX_SifraTeksta");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Aktivna)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.KontoObaveze)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoRealiziraniPdvNeobveznicima)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoRealiziraniPdvObveznicima)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.KontoUkalkulisaneTakse)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OpisKnjizenjaUgk)
                    .HasColumnName("OpisKnjizenjaUGK")
                    .HasMaxLength(100);

                entity.Property(e => e.SifraArtikla)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.SifraGrupeArtikala)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraTeksta)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.KontoObavezeNavigation)
                    .WithMany(p => p.TakseKontoObavezeNavigation)
                    .HasForeignKey(d => d.KontoObaveze)
                    .HasConstraintName("FK_dbo.Takse_dbo.AnalitickaKonta_KontoObaveze");

                entity.HasOne(d => d.KontoRealiziraniPdvNeobveznicimaNavigation)
                    .WithMany(p => p.TakseKontoRealiziraniPdvNeobveznicimaNavigation)
                    .HasForeignKey(d => d.KontoRealiziraniPdvNeobveznicima)
                    .HasConstraintName("FK_dbo.Takse_dbo.AnalitickaKonta_KontoRealiziraniPdvNeobveznicima");

                entity.HasOne(d => d.KontoRealiziraniPdvObveznicimaNavigation)
                    .WithMany(p => p.TakseKontoRealiziraniPdvObveznicimaNavigation)
                    .HasForeignKey(d => d.KontoRealiziraniPdvObveznicima)
                    .HasConstraintName("FK_dbo.Takse_dbo.AnalitickaKonta_KontoRealiziraniPdvObveznicima");

                entity.HasOne(d => d.KontoUkalkulisaneTakseNavigation)
                    .WithMany(p => p.TakseKontoUkalkulisaneTakseNavigation)
                    .HasForeignKey(d => d.KontoUkalkulisaneTakse)
                    .HasConstraintName("FK_dbo.Takse_dbo.AnalitickaKonta_KontoUkalkulisaneTakse");

                entity.HasOne(d => d.SifraArtiklaNavigation)
                    .WithMany(p => p.Takse)
                    .HasForeignKey(d => d.SifraArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Takse_dbo.Artikli_SifraArtikla");

                entity.HasOne(d => d.SifraGrupeArtikalaNavigation)
                    .WithMany(p => p.Takse)
                    .HasForeignKey(d => d.SifraGrupeArtikala)
                    .HasConstraintName("FK_dbo.Takse_dbo.GrupeArtikala_SifraGrupeArtikala");

                entity.HasOne(d => d.SifraTekstaNavigation)
                    .WithMany(p => p.Takse)
                    .HasForeignKey(d => d.SifraTeksta)
                    .HasConstraintName("FK_dbo.Takse_dbo.Tekstovi_SifraTeksta");
            });

            modelBuilder.Entity<Tekstovi>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.Tekstovi");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.IosDobavljaca).HasColumnName("IOS_Dobavljaca");

                entity.Property(e => e.IosKupca).HasColumnName("IOS_Kupca");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis).IsRequired();
            });

            modelBuilder.Entity<TrgovackaKnjigaMaloprodaje>(entity =>
            {
                entity.HasKey(e => new { e.SifraOj, e.RedniBroj })
                    .HasName("PK_dbo.TrgovackaKnjigaMaloprodaje");

                entity.HasIndex(e => e.SifraOj)
                    .HasName("IX_SifraOJ");

                entity.HasIndex(e => e.SifraPoslovnogPartnera)
                    .HasName("IX_SifraPoslovnogPartnera");

                entity.Property(e => e.SifraOj)
                    .HasColumnName("SifraOJ")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RedniBroj)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrojDokumenta)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Razduzenje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SifraPoslovnogPartnera)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Zaduzenje).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.SifraOjNavigation)
                    .WithMany(p => p.TrgovackaKnjigaMaloprodaje)
                    .HasForeignKey(d => d.SifraOj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TrgovackaKnjigaMaloprodaje_dbo.OrganizacioneJedinice_SifraOJ");

                entity.HasOne(d => d.SifraPoslovnogPartneraNavigation)
                    .WithMany(p => p.TrgovackaKnjigaMaloprodaje)
                    .HasForeignKey(d => d.SifraPoslovnogPartnera)
                    .HasConstraintName("FK_dbo.TrgovackaKnjigaMaloprodaje_dbo.PoslovniPartneri_SifraPoslovnogPartnera");
            });

            modelBuilder.Entity<UcescePeriodaNaplate>(entity =>
            {
                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Postotak).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<UgovoreneCijene>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.UgovoreneCijene");

                entity.HasIndex(e => e.KupacId)
                    .HasName("IX_KupacId");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.KupacId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.VrijediOdDatuma).HasColumnType("datetime");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.UgovoreneCijene)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UgovoreneCijene_dbo.PoslovniPartneri_Kupac_Sifra");
            });

            modelBuilder.Entity<Usluge>(entity =>
            {
                entity.HasKey(e => e.SifraUsluge)
                    .HasName("PK_dbo.Usluge");

                entity.HasIndex(e => e.SifraGrupeUsluga)
                    .HasName("IX_SifraGrupeUsluga");

                entity.HasIndex(e => e.SifraPorezneGrupe)
                    .HasName("IX_SifraPorezneGrupe");

                entity.Property(e => e.SifraUsluge)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CijenaUsluge).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.JedinicaMjere)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.KataloskaOznaka)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinObracunaPdva)
                    .IsRequired()
                    .HasColumnName("NacinObracunaPDVa")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NazivUsluge)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SifraGrupeUsluga)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SifraPorezneGrupe)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.HasOne(d => d.SifraGrupeUslugaNavigation)
                    .WithMany(p => p.Usluge)
                    .HasForeignKey(d => d.SifraGrupeUsluga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Usluge_dbo.GrupeUsluga_SifraGrupeUsluga");

                entity.HasOne(d => d.SifraPorezneGrupeNavigation)
                    .WithMany(p => p.Usluge)
                    .HasForeignKey(d => d.SifraPorezneGrupe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Usluge_dbo.PorezneGrupe_SifraPorezneGrupe");
            });

            modelBuilder.Entity<ZavisniTroskovi>(entity =>
            {
                entity.HasKey(e => e.Sifra)
                    .HasName("PK_dbo.ZavisniTroskovi");

                entity.HasIndex(e => e.KontoObaveze)
                    .HasName("IX_KontoObaveze");

                entity.Property(e => e.Sifra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.KontoObaveze)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NacinObracunaIznosa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Osnovica)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.KontoObavezeNavigation)
                    .WithMany(p => p.ZavisniTroskovi)
                    .HasForeignKey(d => d.KontoObaveze)
                    .HasConstraintName("FK_dbo.ZavisniTroskovi_dbo.AnalitickaKonta_KontoObaveze");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
