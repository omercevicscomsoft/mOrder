using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models2
{
    public partial class Pospisaci
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Driver { get; set; }
        public string Workstation { get; set; }
        public string PrintKind { get; set; }
        public string GrupeZaTalon { get; set; }
        public int LineWidth { get; set; }
        public int NumberOfLines { get; set; }
        public bool PrintTime { get; set; }
        public string DocumentTitle { get; set; }
        public string Header1 { get; set; }
        public string Header2 { get; set; }
        public string Header3 { get; set; }
        public string Header4 { get; set; }
        public string Footer1 { get; set; }
        public string Footer2 { get; set; }
        public string Footer3 { get; set; }
        public string CommandInitialize { get; set; }
        public string CommandBoldOn { get; set; }
        public string CommandBoldOff { get; set; }
        public string CommandDoubleWidthOn { get; set; }
        public string CommandDoubleWidthOff { get; set; }
        public string CommandDoubleHeightOn { get; set; }
        public string CommandDoubleHeightOff { get; set; }
        public string CommandUnderlineOn { get; set; }
        public string CommandUnderlineOff { get; set; }
        public string CommandCut { get; set; }
        public string CommandOpenDrawer { get; set; }
        public bool Aktivan { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool ProcessLatinCharacters { get; set; }
        public bool DisableLatinCharacters { get; set; }
        public string CommandDoubleOn { get; set; }
        public string CommandDoubleOff { get; set; }
        public bool GenericDriver { get; set; }
    }
}
