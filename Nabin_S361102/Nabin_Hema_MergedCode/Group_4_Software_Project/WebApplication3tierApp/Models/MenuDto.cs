using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class MenuDto
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
                        
    }

    public static class MenuDtoMapExtensions
    {
        public static MenuDto ToMenuDto(this MenuModel src)
        {
            var dst = new MenuDto();
            dst.MenuId = src.MenuId;
            dst.MenuName = src.MenuName;            
            return dst;
        }

        public static MenuModel ToMenuModel(this MenuDto src)
        {
            var dst = new MenuModel();
            dst.MenuId = src.MenuId;
            dst.MenuName = src.MenuName;            
            return dst;
        }
    }
}
