using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IMenuService
    {
        Task<MenuModel?> GetById(int MenuId);
        Task<List<MenuModel>> GetAll();

        Task<int> CreateMenu(MenuModel MenuModel);
        Task UpdateMenu(MenuModel MenuModel);
        Task DeleteMenu(int Menu);
    }
}
