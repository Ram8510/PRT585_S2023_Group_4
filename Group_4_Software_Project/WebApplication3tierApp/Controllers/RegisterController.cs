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
    public class RegisterController : BaseController
    {

        private readonly IRegisterService _RegisterService;
        private readonly ILogger<RegisterController> _logger;

        public RegisterController(IRegisterService RegisterService, ILogger<RegisterController> logger)
        {
            _RegisterService = RegisterService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllRegisters")]
        public async Task<List<RegisterDto>> GetAll()
        {
            var result = await _RegisterService.GetAll();
            return result.Select(x => x.ToRegisterDto()).ToList();
        }

        [HttpGet("{RegisterId}", Name = "GetRegister")]
        public async Task<RegisterDto?> Get(int RegisterId)
        {
            var result = await _RegisterService.GetById(RegisterId);
            return result?.ToRegisterDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] RegisterDto requestDto)
        {
            var RegisterModel = requestDto.ToRegisterModel();
            return await _RegisterService.CreateRegister(RegisterModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] RegisterDto requestDto)
        {
            await _RegisterService.UpdateRegister(requestDto.ToRegisterModel());
            return Ok();
        }

        [HttpDelete, Route("{RegisterId}")]
        public async Task<IActionResult> Delete(int RegisterId)
        {
            await _RegisterService.DeleteRegister(RegisterId);
            return Ok();
        }
    }
}
