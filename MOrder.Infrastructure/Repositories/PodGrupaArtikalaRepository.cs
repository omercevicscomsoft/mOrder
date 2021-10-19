using Microsoft.EntityFrameworkCore;
using MOrder.Core.Models;
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
    internal class PodGrupaArtikalaRepository : BaseRepository<PodgrupeArtikala>, IPodGrupeArtikalaRepository
    {
        internal PodGrupaArtikalaRepository(DBContext context) : base(context)
        {

        }
        public async Task<IEnumerable<OutPodGrupeArtikala>> GetAsync(string sifraGrupeArtikla)
        {
            return await this.Entity(false).Where(pga => pga.SifraGrupe == sifraGrupeArtikla)
                  .Select(pga => new OutPodGrupeArtikala
                  {
                      Naziv = pga.Naziv,
                      Sifra = pga.Sifra,
                      SifraGrupe = pga.SifraGrupe,
                      Slika = pga.Slika
                  })
                  .ToListAsync();
                  
        }
    }
}
