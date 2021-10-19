using MOrder.Infrastructure.DTOs.Output;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Interfaces
{
    public interface IPodGrupeArtikalaRepository
    {
        Task<IEnumerable<OutPodGrupeArtikala>> GetAsync(string sifraGrupeArtikla);
    }
}
