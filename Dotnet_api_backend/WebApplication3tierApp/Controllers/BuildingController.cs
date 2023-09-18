using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [AllowAnonymous]
    public class BuildingController : BaseController
    {

        private readonly IBuildingService _BuildingService;
        private readonly ILogger<BuildingController> _logger;

        public BuildingController(IBuildingService BuildingService, ILogger<BuildingController> logger)
        {
            _BuildingService = BuildingService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllBuildings")]
        public async Task<List<BuildingDto>> GetAll()
        {
            var result = await _BuildingService.GetAll();
            return result.Select(x => x.ToBuildingDto()).ToList();
        }

        [HttpGet("{BuildingId}", Name = "GetBuilding")]
        public async Task<BuildingDto?> Get(int BuildingId)
        {
            var result = await _BuildingService.GetById(BuildingId);
            return result?.ToBuildingDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] BuildingDto requestDto)
        {
            var BuildingModel = requestDto.ToBuildingModel();
            return await _BuildingService.CreateBuilding(BuildingModel);
        }

        [HttpPut, Route("{BuildingId}")]
        public async Task<IActionResult> Update([FromBody] BuildingDto requestDto)
        {
            await _BuildingService.UpdateBuilding(requestDto.ToBuildingModel());
            return Ok();
        }

        [HttpDelete, Route("{BuildingId}")]
        public async Task<IActionResult> Delete(int BuildingId)
        {
            await _BuildingService.DeleteBuilding(BuildingId);
            return Ok();
        }
    }
}
