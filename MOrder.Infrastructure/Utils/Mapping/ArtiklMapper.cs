using MOrder.Core.Models2;
using MOrder.Infrastructure.DTOs.Output;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.Utils.Mapping
{
    public class ArtiklMapper
    {
        public static OutArtikl Map(Artikli artikl)
        {
            return new OutArtikl
            {
                Sifra = artikl.Sifra,
                Cijena = artikl.Cijena,
                Naziv = artikl.Naziv,
                Slika = artikl.Slika,
                SifraGrupeArtikala = artikl.SifraGrupeArtikala,
                SifraPodgrupeArtikala = artikl.SifraPodgrupeArtikala
            };
        }
    }
}
