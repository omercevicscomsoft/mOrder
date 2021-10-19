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
    public class PodGrupaArtikalaController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public PodGrupaArtikalaController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet("{sifraGrupe}")]
        public async Task<IActionResult> GetGrupaArtikala(string sifraGrupe)
        {
            var grupe = await _repositoryManager.PodGrupeArtikalaRepository.GetAsync(sifraGrupe);

            return Ok(grupe);
        }
    }
}
