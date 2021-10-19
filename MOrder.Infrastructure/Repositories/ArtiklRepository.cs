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
    internal class ArtiklRepository : BaseRepository<Artikli>, IArtiklRepository
    {
        internal ArtiklRepository(DBContext context) : base(context)
        {

        }

        public async Task<IEnumerable<OutArtikl>> GetAsyncBySifraOrganizacioneJedinice(string sifraOJ, bool trackChanges = false)
        {
            return await base.Entity(trackChanges)
              .Where(ar => ar.SifraOj == sifraOJ && ar.Aktivan && ar.ZaPos)
              .Select(ar => new OutArtikl
              {
                  Cijena = ar.Cijena,
                  SifraPodgrupeArtikala= ar.SifraPodgrupeArtikala,
                  Naziv= ar.Naziv,
                  Sifra= ar.Sifra,
                  SifraGrupeArtikala= ar.SifraGrupeArtikala,
                  Slika = ar.Slika

              })
              .ToListAsync();
        }
    }
}
