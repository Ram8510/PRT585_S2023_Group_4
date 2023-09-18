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
    public class SongController : BaseController
    {

        private readonly ISongService _SongService;
        private readonly ILogger<SongController> _logger;

        public SongController(ISongService SongService, ILogger<SongController> logger)
        {
            _SongService = SongService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllSongs")]
        public async Task<List<SongDto>> GetAll()
        {
            var result = await _SongService.GetAll();
            return result.Select(x => x.ToSongDto()).ToList();
        }

        [HttpGet("{SongId}", Name = "GetSong")]
        public async Task<SongDto?> Get(int SongId)
        {
            var result = await _SongService.GetById(SongId);
            return result?.ToSongDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] SongDto requestDto)
        {
            var SongModel = requestDto.ToSongModel();
            return await _SongService.CreateSong(SongModel);
        }

        [HttpPut, Route("{SongId}")]
        public async Task<IActionResult> Update([FromBody] SongDto requestDto)
        {
            await _SongService.UpdateSong(requestDto.ToSongModel());
            return Ok();
        }

        [HttpDelete, Route("{SongId}")]
        public async Task<IActionResult> Delete(int SongId)
        {
            await _SongService.DeleteSong(SongId);
            return Ok();
        }
    }
}
