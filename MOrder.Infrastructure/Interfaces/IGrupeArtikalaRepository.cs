using MOrder.Infrastructure.DTOs.Output;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Interfaces
{
    public interface IGrupeArtikalaRepository
    {
        Task<OutGrupeArtikala> GetAsync(string sifraGrupeArtikla);
    }
}
