using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOrder.Infrastructure.DTOs.Input;
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
    public class MobileOrderItemController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public MobileOrderItemController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] InMobileOrderItemDTO mobileOrderItemDTO)
        {
            var mobileOrderItem = MobileOrderItemMapper.Map(mobileOrderItemDTO);

            _repositoryManager.MobileOrderItemRepository.Create(mobileOrderItem);


            await _repositoryManager.SaveAsync();

            return Ok(true);
        }
    }
}
