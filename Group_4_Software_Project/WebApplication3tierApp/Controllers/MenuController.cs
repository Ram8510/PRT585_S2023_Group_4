/*using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class MenuController : BaseController
    {

        private readonly IMenuService _MenuService;
        private readonly ILogger<MenuController> _logger;

        public MenuController(IMenuService MenuService, ILogger<MenuController> logger)
        {
            _MenuService = MenuService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllMenus")]
        public async Task<List<MenuDto>> GetAll()
        {
            var result = await _MenuService.GetAll();
            return result.Select(x => x.ToMenuDto()).ToList();
        }

        [HttpGet("{MenuId}", Name = "GetMenu")]
        public async Task<MenuDto?> Get(int MenuId)
        {
            var result = await _MenuService.GetById(MenuId);
            return result?.ToMenuDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] MenuDto requestDto)
        {
            var MenuModel = requestDto.ToMenuModel();
            return await _MenuService.CreateMenu(MenuModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] MenuDto requestDto)
        {
            await _MenuService.UpdateMenu(requestDto.ToMenuModel());
            return Ok();
        }

        [HttpDelete, Route("{MenuId}")]
        public async Task<IActionResult> Delete(int MenuId)
        {
            await _MenuService.DeleteMenu(MenuId);
            return Ok();
        }
    }
}
*/