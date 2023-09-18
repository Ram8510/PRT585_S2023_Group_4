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
    public class InstrumentController : BaseController
    {

        private readonly IInstrumentService _InstrumentService;
        private readonly ILogger<InstrumentController> _logger;

        public InstrumentController(IInstrumentService InstrumentService, ILogger<InstrumentController> logger)
        {
            _InstrumentService = InstrumentService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllInstruments")]
        public async Task<List<InstrumentDto>> GetAll()
        {
            var result = await _InstrumentService.GetAll();
            return result.Select(x => x.ToInstrumentDto()).ToList();
        }

        [HttpGet("{InstrumentId}", Name = "GetInstrument")]
        public async Task<InstrumentDto?> Get(int InstrumentId)
        {
            var result = await _InstrumentService.GetById(InstrumentId);
            return result?.ToInstrumentDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] InstrumentDto requestDto)
        {
            var InstrumentModel = requestDto.ToInstrumentModel();
            return await _InstrumentService.CreateInstrument(InstrumentModel);
        }

        [HttpPut, Route("{InstrumentId}")]
        public async Task<IActionResult> Update([FromBody] InstrumentDto requestDto)
        {
            await _InstrumentService.UpdateInstrument(requestDto.ToInstrumentModel());
            return Ok();
        }

        [HttpDelete, Route("{InstrumentId}")]
        public async Task<IActionResult> Delete(int InstrumentId)
        {
            await _InstrumentService.DeleteInstrument(InstrumentId);
            return Ok();
        }
    }
}
