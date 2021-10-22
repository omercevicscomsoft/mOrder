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
    public class LoginController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public LoginController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        [HttpPost()]
        public async Task<IActionResult> GetAsync([FromBody] InLoginDTO loginDTO)
        {
            var prodavac = await _repositoryManager.ProdavacRepository.GetAsync(loginDTO.UserName, loginDTO.Password);

            if (prodavac == null)
            {
                return NotFound();
            }

            return Ok(UserMapper.Map(prodavac));
        }
    }
}
