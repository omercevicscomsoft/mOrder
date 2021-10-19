using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.DTOs.Output
{
    public class OutArtikl
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public string Sifra { get; set; }
        public byte[] Slika { get; set; }
        public string SifraGrupeArtikala { get; set; }
        public string SifraPodgrupeArtikala { get; set; }
        
    }
}
