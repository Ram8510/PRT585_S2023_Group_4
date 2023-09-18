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
    public class ClubController : BaseController
    {

        private readonly IClubService _ClubService;
        private readonly ILogger<ClubController> _logger;

        public ClubController(IClubService ClubService, ILogger<ClubController> logger)
        {
            _ClubService = ClubService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllClubs")]
        public async Task<List<ClubDto>> GetAll()
        {
            var result = await _ClubService.GetAll();
            return result.Select(x => x.ToClubDto()).ToList();
        }

        [HttpGet("{ClubId}", Name = "GetClub")]
        public async Task<ClubDto?> Get(int ClubId)
        {
            var result = await _ClubService.GetById(ClubId);
            return result?.ToClubDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] ClubDto requestDto)
        {
            var ClubModel = requestDto.ToClubModel();
            return await _ClubService.CreateClub(ClubModel);
        }

        [HttpPut, Route("{ClubId}")]
        public async Task<IActionResult> Update([FromBody] ClubDto requestDto)
        {
            await _ClubService.UpdateClub(requestDto.ToClubModel());
            return Ok();
        }

        [HttpDelete, Route("{ClubId}")]
        public async Task<IActionResult> Delete(int ClubId)
        {
            await _ClubService.DeleteClub(ClubId);
            return Ok();
        }
    }
}
