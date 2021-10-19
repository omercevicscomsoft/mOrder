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
    public class MobileOrderController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public MobileOrderController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] InMobileOrderDTO mobileOrderDTO)
        {
            var mobileOrder = MobileOrderMapper.Map(mobileOrderDTO);

            mobileOrder=_repositoryManager.MobileOrderRepository.Create(mobileOrder);


            await _repositoryManager.SaveAsync();

            return Ok(mobileOrder);
        }
    }
}
