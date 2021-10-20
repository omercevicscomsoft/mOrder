using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MOrder.Infrastructure.DTOs.Input;
using MOrder.Infrastructure.Hubs;
using MOrder.Infrastructure.Interfaces;
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

            mobileOrder=_repositoryManager.MobileOrderRepository.Create(mobileOrder);


            await _repositoryManager.SaveAsync();

            await this._hubContext.Clients.All.Update(mobileOrder);

            return Ok(mobileOrder);
        }
    }
}
