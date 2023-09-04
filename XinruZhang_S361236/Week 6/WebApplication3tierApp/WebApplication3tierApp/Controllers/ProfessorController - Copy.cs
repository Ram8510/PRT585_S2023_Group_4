using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProfessorController : BaseController
    {

        private readonly IProfessorService _ProfessorService;
        private readonly ILogger<ProfessorController> _logger;

        public ProfessorController(IProfessorService ProfessorService, ILogger<ProfessorController> logger)
        {
            _ProfessorService = ProfessorService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllProfessors")]
        public async Task<List<ProfessorDto>> GetAll()
        {
            var result = await _ProfessorService.GetAll();
            return result.Select(x => x.ToProfessorDto()).ToList();
        }

        [HttpGet("{ProfessorId}", Name = "GetProfessor")]
        public async Task<ProfessorDto?> Get(int ProfessorId)
        {
            var result = await _ProfessorService.GetById(ProfessorId);
            return result?.ToProfessorDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] ProfessorDto requestDto)
        {
            var ProfessorModel = requestDto.ToProfessorModel();
            return await _ProfessorService.CreateProfessor(ProfessorModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] ProfessorDto requestDto)
        {
            await _ProfessorService.UpdateProfessor(requestDto.ToProfessorModel());
            return Ok();
        }

        [HttpDelete, Route("{ProfessorId}")]
        public async Task<IActionResult> Delete(int ProfessorId)
        {
            await _ProfessorService.DeleteProfessor(ProfessorId);
            return Ok();
        }
    }
}
