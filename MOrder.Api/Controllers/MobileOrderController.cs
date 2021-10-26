using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MOrder.Infrastructure.DTOs.Input;
using MOrder.Infrastructure.Extensions;
using MOrder.Infrastructure.Hubs;
using MOrder.Infrastructure.Interfaces;
using MOrder.Infrastructure.Models;
using MOrder.Infrastructure.Utils.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOrder.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MobileOrderController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IHubContext<SignalRHub, ISignalRHub> _hubContext;

        public MobileOrderController(IRepositoryManager repositoryManager, IHubContext<SignalRHub, ISignalRHub> hubContext)
        {
            _repositoryManager = repositoryManager;
            _hubContext = hubContext;
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] InMobileOrderDTO mobileOrderDTO)
        {
            var mobileOrder = MobileOrderMapper.Map(mobileOrderDTO);
           
            mobileOrder = _repositoryManager.MobileOrderRepository.Create(mobileOrder);
            
            await _repositoryManager.SaveAsync();
            foreach (var item in mobileOrderDTO.OrderItems)
            {
                item.MobileOrderId = mobileOrder.Id;
                var orderItem = MobileOrderItemMapper.Map(item);
                mobileOrder.MobileOrderItems.Add(_repositoryManager.MobileOrderItemRepository.Create(orderItem));
            }
            await _repositoryManager.SaveAsync();
            mobileOrder = await _repositoryManager.MobileOrderRepository.GetAsync(mobileOrder.Id);

            await _hubContext.Clients.All.Update(MobileOrderMapper.Map(mobileOrder));

            return Ok(mobileOrder);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] InMobileOrderDTO mobileOrderDTO, int id)
        {
            var mobileOrder = await _repositoryManager.MobileOrderRepository.GetAsync(id);
            if (mobileOrder == null)
                return NotFound();

            if(mobileOrderDTO.OrderItems.Count()<mobileOrder.MobileOrderItems.Count())
            {
                foreach (var order in mobileOrder.MobileOrderItems)
                {
                    if(mobileOrderDTO.OrderItems.Find(x=>x.Id==order.Id) == null)
                    {
                        _repositoryManager.MobileOrderItemRepository.Delete(order);

                    }
                }
            }

            foreach (var item in mobileOrderDTO.OrderItems)
            {
                var orderItem = MobileOrderItemMapper.Map(item);
              
                if (mobileOrder.MobileOrderItems.Any(x => x.Id == orderItem.Id))
                {
                    var orOrder = mobileOrder.MobileOrderItems.First(x => x.Id == orderItem.Id);
                    orOrder.Kolicina = orderItem.Kolicina;
                } else
                {
                    mobileOrder.MobileOrderItems.Add(_repositoryManager.MobileOrderItemRepository.Create(orderItem));
                    await _repositoryManager.SaveAsync();
                }
                
            }
            mobileOrder.Update(mobileOrderDTO);
            mobileOrder = _repositoryManager.MobileOrderRepository.Update(mobileOrder);
            await _repositoryManager.SaveAsync();
            mobileOrder = await _repositoryManager.MobileOrderRepository.GetAsync(mobileOrder.Id);
            await _hubContext.Clients.All.Update(MobileOrderMapper.Map(mobileOrder));
            return Ok(mobileOrder);
        }

        [HttpGet()]
        public async Task<IActionResult> GetAsync()
        {
            var mobileOrders = await _repositoryManager.MobileOrderRepository.GetAsync();

            return Ok(mobileOrders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var mobileOrder = await _repositoryManager.MobileOrderRepository.GetAsync(id);

            return Ok(mobileOrder);
        }

        [HttpGet("prodavac/{username}")]
        public async Task<IActionResult> GetAsync(string username)
        {
            var mobileOrders = await _repositoryManager.MobileOrderRepository.GetAsync(username);

            return Ok(mobileOrders);
        }

        [HttpPut("{id}/status/{orderStatus}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromRoute] int orderStatus)
        {
            var mobileOrder = await _repositoryManager.MobileOrderRepository.GetAsyncRoot(id);

            if (mobileOrder == null)
            {
                return Ok(mobileOrder);
            }
            mobileOrder.Update(orderStatus);

            mobileOrder = _repositoryManager.MobileOrderRepository.Update(mobileOrder);

            await _repositoryManager.SaveAsync();
            await _hubContext.Clients.All.Update(MobileOrderMapper.Map(mobileOrder));
            return Ok(mobileOrder);
        }

        [HttpDelete("id/{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            var mobileOrder = await _repositoryManager.MobileOrderRepository.GetAsync(id);

            if (mobileOrder == null || mobileOrder.Status>0)
            {
                return NotFound();
            }

            _repositoryManager.MobileOrderRepository.Delete(mobileOrder);

            await _repositoryManager.SaveAsync();
            mobileOrder.MobileOrderItems = null;
            await _hubContext.Clients.All.Update(MobileOrderMapper.Map(mobileOrder));
            return Ok(mobileOrder);
        }
    }
}
