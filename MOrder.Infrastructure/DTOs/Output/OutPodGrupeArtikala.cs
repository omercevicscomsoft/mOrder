using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.DTOs.Output
{
    public class OutPodGrupeArtikala
    {
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public string SifraGrupe { get; set; }
        public byte[] Slika { get; set; }
    }
}
