using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class PostavkaIspisaRacuna
    {
        public string OrganizacionaJedinicaId { get; set; }
        public bool IspisRekapitulacijePoPoreznimGrupama { get; set; }
        public bool IspisOtpremnice { get; set; }
        public bool IspisUdomacojValuti { get; set; }
        public bool PrintPreview { get; set; }
        public string FormatRacunaId { get; set; }
        public int BrojKopija { get; set; }
        public int BrojDecimalaKolicina { get; set; }
        public int BrojDecimalaCijena { get; set; }
        public int NacinIspisaFiskalnihDokumenata { get; set; }
        public int BrojFiskalnihDokumenataUgrupi { get; set; }
        public string ValutaId { get; set; }
        public string DodatniTekst { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool RacunMpnaFiskalniUjednojStavci { get; set; }
        public bool IspisBarKodaTekst { get; set; }
        public bool IspisBarKodaGrafika { get; set; }
        public bool IspisProizvodjaca { get; set; }
        public bool IspisKlasifikacije { get; set; }
        public bool IspisKataloskeOznake { get; set; }
        public string KlasifikacijaNaslov { get; set; }
        public string KataloskaOznakaNaslov { get; set; }
        public string ProizvodjacNaslov { get; set; }
        public int BrojDecimalaIznos { get; set; }
        public bool IspisCijenaNaOtpremnici { get; set; }
        public bool IspisRacunaUposlovneSvrheNaFiskalniPisac { get; set; }
    }
}
