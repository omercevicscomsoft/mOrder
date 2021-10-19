using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOrder.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOrder.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtiklController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public ArtiklController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet("{sifraOJ}")]
        public async Task<IActionResult> GetArtikli(string sifraOJ)
        {
            var artikli = await _repositoryManager.ArtiklRepository.GetAsyncBySifraOrganizacioneJedinice(sifraOJ);

            return Ok(artikli);
        }
    }
}
