using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class NaljepnicaUroli
    {
        public string NaljepnicaUroliId { get; set; }
        public string Opis { get; set; }
        public int NaljepnicaRolaVrstaId { get; set; }
        public int SirinaRazmaka { get; set; }
        public int TipKomunikacije { get; set; }
        public int Dpi { get; set; }
        public int ProgramskiJezik { get; set; }
        public int OrjentacijaIspisa { get; set; }
        public string PrinterName { get; set; }
        public string ParalelPortName { get; set; }
        public string SerialPortName { get; set; }
        public int SerialPortBaudRate { get; set; }
        public int SerialPortDataBits { get; set; }
        public int SerialPortHandshake { get; set; }
        public int SerialPortParity { get; set; }
        public int SerialPortStopBits { get; set; }
        public string IpadresaPisaca { get; set; }
        public int NetworkPort { get; set; }
        public int BrojKopija { get; set; }
        public bool PrintAsGraphic { get; set; }
        public bool Aktivan { get; set; }
        public bool Default { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
