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
    public class BorrowController : BaseController
    {

        private readonly IBorrowService _BorrowService;
        private readonly ILogger<BorrowController> _logger;

        public BorrowController(IBorrowService BorrowService, ILogger<BorrowController> logger)
        {
            _BorrowService = BorrowService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllBorrows")]
        public async Task<List<BorrowDto>> GetAll()
        {
            var result = await _BorrowService.GetAll();
            return result.Select(x => x.ToBorrowDto()).ToList();
        }

        [HttpGet("{BorrowId}", Name = "GetBorrow")]
        public async Task<BorrowDto?> Get(int BorrowId)
        {
            var result = await _BorrowService.GetById(BorrowId);
            return result?.ToBorrowDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] BorrowDto requestDto)
        {
            var BorrowModel = requestDto.ToBorrowModel();
            return await _BorrowService.CreateBorrow(BorrowModel);
        }

        [HttpPut, Route("{BorrowId}")]
        public async Task<IActionResult> Update([FromBody] BorrowDto requestDto)
        {
            await _BorrowService.UpdateBorrow(requestDto.ToBorrowModel());
            return Ok();
        }

        [HttpDelete, Route("{BorrowId}")]
        public async Task<IActionResult> Delete(int BorrowId)
        {
            await _BorrowService.DeleteBorrow(BorrowId);
            return Ok();
        }
    }
}
