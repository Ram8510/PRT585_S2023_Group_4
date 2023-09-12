/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuDal _MenuDal;
        //private readonly IMenuBalService _MenuBalService;
        public MenuService(IMenuDal MenuDal
        //ILoggingService loggingService,
        //IMenuDal MenuDal,
        //IAuditDal auditDal
        // IMenuBalanceService balsvc
        )
        {
            _MenuDal = MenuDal;
            // _MenuBalService = balsvc;
        }

        public async Task<MenuModel?> GetById(int MenuId)
        {
            return _MenuDal.GetById(MenuId);
        }

        public async Task<List<MenuModel>> GetAll()
        {
            return _MenuDal.GetAll();
        }

        public async Task<int> CreateMenu(MenuModel Menu)
        {

            //write validations here
            var newMenuId = _MenuDal.CreateMenu(Menu);
            return newMenuId;
        }

        public async Task UpdateMenu(MenuModel Menu)
        {
            //write validations here 
            _MenuDal.UpdateMenu(Menu);
        }

        public async Task DeleteMenu(int MenuId)
        {
            try
            {

                //if(_PayService.getBal(MenuId) = 0)
                _MenuDal.DeleteMenu(MenuId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Menu Id:{MenuId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
*/