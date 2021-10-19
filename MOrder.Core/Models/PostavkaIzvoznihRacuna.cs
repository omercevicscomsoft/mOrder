using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class PostavkaIzvoznihRacuna
    {
        public string OrganizacionaJedinicaId { get; set; }
        public bool AktivnePostavke { get; set; }
        public string TekstKojiSeDodajeNazivuArtikla { get; set; }
        public int PozicijaTekstaKojiSeDodajeNazivuArtikla { get; set; }
        public string PoreznaGrupaId { get; set; }
        public bool PrimjenitiOvuPoreznuGrupu { get; set; }
        public string NacinObracunaPdva { get; set; }
        public bool PrimjenitiOvajNacinObracunaPdva { get; set; }
        public string DodatniTekst { get; set; }
        public bool IspisOvogDodatnogTeksta { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
