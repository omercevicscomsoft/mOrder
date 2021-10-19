using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class FiskalniPisaci
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string ServerHost { get; set; }
        public int ServerPort { get; set; }
        public string CommandFolder { get; set; }
        public string ResponseFolder { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public int Proizvodac { get; set; }
        public string Workstation { get; set; }
        public string Ibfu { get; set; }
        public int LineWidth { get; set; }
        public bool PopustiSaZarezom { get; set; }
        public string Iosa { get; set; }
        public string SerijskiBroj { get; set; }
        public int LogickiBroj { get; set; }
        public string CommandFile { get; set; }
        public string ResponseFile { get; set; }
        public string Prodavac { get; set; }
        public string LozinkaProdavaca { get; set; }
        public string BackUpFolder { get; set; }
        public string ErrorFolder { get; set; }
        public bool Aktivan { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string LocalClientBase { get; set; }
        public string LocalItemsBase { get; set; }
        public bool DisplayExists { get; set; }
        public bool AllowDuplicateItem { get; set; }
        public bool? PohranaArtikalaUpisac { get; set; }
        public bool NoviUredaj { get; set; }
    }
}
