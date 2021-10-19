using MOrder.Infrastructure.Context;
using MOrder.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOrder.Infrastructure.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DBContext _context;
        private IArtiklRepository _artiklRepository;
        private IGrupeArtikalaRepository _grupeArtikalaRepository;
        private IPodGrupeArtikalaRepository _podGrupeArtikalaRepository;
        private IMobileOrderRepository _mobileOrderRepository;
        private IMobileOrderItemRepository _mobileOrderItemRepository;

        public RepositoryManager(DBContext context)
        {
            this._context = context;
        }

        public IArtiklRepository ArtiklRepository
        {
            get
            {
                if (_artiklRepository == null)
                {
                    _artiklRepository = new ArtiklRepository(_context);
                }
                return _artiklRepository;
            }
        }

        public IGrupeArtikalaRepository GrupeArtikalaRepository
        {
            get
            {
                if (_grupeArtikalaRepository == null)
                {
                    _grupeArtikalaRepository = new GrupaArtikalaRepository(_context);
                }
                return _grupeArtikalaRepository;
            }
        }

        public IPodGrupeArtikalaRepository PodGrupeArtikalaRepository
        {
            get
            {
                if (_podGrupeArtikalaRepository == null)
                {
                    _podGrupeArtikalaRepository = new PodGrupaArtikalaRepository(_context);
                }
                return _podGrupeArtikalaRepository;
            }
        }

        public IMobileOrderRepository MobileOrderRepository
        {
            get
            {
                if (_mobileOrderRepository == null)
                {
                    _mobileOrderRepository = new MobileOrderRepository(_context);
                }
                return _mobileOrderRepository;
            }
        }

        public IMobileOrderItemRepository MobileOrderItemRepository
        {
            get
            {
                if (_mobileOrderItemRepository == null)
                {
                    _mobileOrderItemRepository = new MobileOrderItemRepository(_context);
                }
                return _mobileOrderItemRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
