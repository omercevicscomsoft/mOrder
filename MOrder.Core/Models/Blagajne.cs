using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MOrder.Core.Models
{
    public partial class Blagajne
    {
        public Blagajne()
        {
            NaloziBlagajne = new HashSet<NaloziBlagajne>();
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string KontoPrometa { get; set; }
        public string SifraValute { get; set; }
        public string SifraOj { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SifraGrupeNaloga { get; set; }
        public string Blagajnik { get; set; }

        public virtual AnalitickaKonta KontoPrometaNavigation { get; set; }
        public virtual GrupeNalogaGk SifraGrupeNalogaNavigation { get; set; }
        public virtual OrganizacioneJedinice SifraOjNavigation { get; set; }
        public virtual KursnaLista SifraValuteNavigation { get; set; }
        public virtual ICollection<NaloziBlagajne> NaloziBlagajne { get; set; }
    }
}
