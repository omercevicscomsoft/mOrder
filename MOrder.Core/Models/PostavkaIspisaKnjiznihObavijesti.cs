using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class PostavkaIspisaKnjiznihObavijesti
    {
        public string OrganizacionaJedinicaId { get; set; }
        public string VrstaKnjizneObavijestiId { get; set; }
        public bool IspisRekapitulacijePoPoreznimGrupama { get; set; }
        public bool IspisOtpremnice { get; set; }
        public bool IspisUdomacojValuti { get; set; }
        public bool PrintPreview { get; set; }
        public string FormatKnjizneObavijestiId { get; set; }
        public int BrojKopija { get; set; }
        public int BrojDecimalaKolicina { get; set; }
        public int BrojDecimalaCijena { get; set; }
        public int NacinIspisaFiskalnihDokumenata { get; set; }
        public int BrojFiskalnihDokumenataUgrupi { get; set; }
        public string ValutaId { get; set; }
        public string DodatniTekst { get; set; }
        public string TekstIspodNaslova { get; set; }
        public bool IspisOvogTekstaIspodNaslova { get; set; }
        public string TekstSaglasnostiKnjizenja { get; set; }
        public bool IspisOvogTekstaSaglasnostiKnjizenja { get; set; }
        public bool IspisFiskalnogDokumenta { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
