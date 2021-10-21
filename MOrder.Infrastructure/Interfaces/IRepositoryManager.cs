using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Interfaces
{
    public interface IRepositoryManager
    {
        IArtiklRepository ArtiklRepository { get; }
        IGrupeArtikalaRepository GrupeArtikalaRepository { get; }
        IPodGrupeArtikalaRepository PodGrupeArtikalaRepository { get; }
        IMobileOrderRepository MobileOrderRepository { get; }
        IMobileOrderItemRepository MobileOrderItemRepository { get; }
        IProdavacRepository ProdavacRepository { get; }
        Task SaveAsync();
    }
}
