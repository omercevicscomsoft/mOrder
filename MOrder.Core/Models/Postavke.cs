using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Postavke
    {
        public int Id { get; set; }
        public string FtpPosluzitelj { get; set; }
        public int FtpPort { get; set; }
        public string FtpKorisnickoIme { get; set; }
        public string FtpLozinka { get; set; }
        public string FtpLokalnaMapa { get; set; }
        public string FtpMapaPosluzitelja { get; set; }
        public string SkinName { get; set; }
        public bool SaveGridLayout { get; set; }
        public bool NaglasitiSvakiDrugiRed { get; set; }
        public string SerialPortName { get; set; }
        public int BaudRate { get; set; }
        public int Timeout { get; set; }
        public bool ModemExists { get; set; }
        public string EmailSendError { get; set; }
        public bool SendError { get; set; }
        public string EmailHost { get; set; }
        public int EmailPort { get; set; }
        public bool EmailSsl { get; set; }
        public string EmailFrom { get; set; }
        public string EmailUserName { get; set; }
        public string EmailPassword { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool PrikazPovjeriocaLijevo { get; set; }
        public string TextKompenzacijeHeader { get; set; }
        public string TextKompenzacijeFooter { get; set; }
        public string PrenosOpisaGk { get; set; }
        public string PrenosDatumaGk { get; set; }
        public string FormiranjeVezeUprometima { get; set; }
        public bool PreuzimatiOpisIzOtvorenihStavki { get; set; }
        public bool KontrolisatiPumpneStanice { get; set; }
        public string SifraOrganizacioneJedinice { get; set; }
        public string RezimRada { get; set; }
        public string MapaTrenutneTransakcije { get; set; }
        public string MapaOdgodeneTransakcije { get; set; }
        public string Separator { get; set; }
        public string PrefiksUimenuDatoteke { get; set; }
        public int BrojPumpnihStanica { get; set; }
        public string EkstenzijaObradeneDatoteke { get; set; }
        public string SifraArtiklaPumpe1 { get; set; }
        public string SifraArtikla1 { get; set; }
        public string SifraArtiklaPumpe2 { get; set; }
        public string SifraArtikla2 { get; set; }
        public string SifraArtiklaPumpe3 { get; set; }
        public string SifraArtikla3 { get; set; }
        public string SifraArtiklaPumpe4 { get; set; }
        public string SifraArtikla4 { get; set; }
        public string SifraArtiklaPumpe5 { get; set; }
        public string SifraArtikla5 { get; set; }
        public string SifraArtiklaPumpe6 { get; set; }
        public string SifraArtikla6 { get; set; }
        public string SifraArtiklaPumpe7 { get; set; }
        public string SifraArtikla7 { get; set; }
        public string SifraArtiklaPumpe8 { get; set; }
        public string SifraArtikla8 { get; set; }
        public string SifraArtiklaPumpe9 { get; set; }
        public string SifraArtikla9 { get; set; }
        public string NacinUpravljanjaBp { get; set; }
        public string EkstenzijaDatotekeKojaSePrati { get; set; }
        public string EkifKufFolder { get; set; }
        public bool EkifKufFolderAddClientSubFolder { get; set; }
        public bool ForsirajPrezimanjeBrojaNalogaIzGlavneKnjige { get; set; }
        public string PopunjeniObrasciFolder { get; set; }
        public bool PopunjeniObrasciAddClientSubFolder { get; set; }
        public string PrazanObrazacFiafileName { get; set; }
        public string PrazanObrazacBilanceFileName { get; set; }
        public string NacinFormiranjaImenaDatotekaBilanci { get; set; }
        public bool ForsiratiFormiranjeMpkalkulacijePriPrenosu { get; set; }
    }
}
