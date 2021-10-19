using Microsoft.EntityFrameworkCore;
using MOrder.Core.Models2;
using MOrder.Infrastructure.Context;
using MOrder.Infrastructure.DTOs.Output;
using MOrder.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Repositories
{
    class GrupaArtikalaRepository : BaseRepository<GrupeArtikala>, IGrupeArtikalaRepository
    {
        internal GrupaArtikalaRepository(DBContext context) : base(context)
        {

        }
        public async Task<OutGrupeArtikala> GetAsync(string sifraGrupeArtikla)
        {
            return await this.Entity(false).Where(pga => pga.Sifra == sifraGrupeArtikla)
                  .Select(pga => new OutGrupeArtikala
                  {
                      Naziv = pga.Naziv,
                      Sifra = pga.Sifra,
                      Slika = pga.Slika
                  })
                  .FirstOrDefaultAsync();

        }
    }
}
