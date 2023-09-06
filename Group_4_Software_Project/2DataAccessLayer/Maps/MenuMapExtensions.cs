/*using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class MenuMapExtensions
    {
        public static MenuModel ToMenuModel(this Menu src)
        {
            var dst = new MenuModel();

            dst.MenuId = src.MenuId;
            dst.MenuName = src.MenuName;

            return dst;
        }

        public static Menu ToMenu(this MenuModel src, Menu dst = null)
        {
            if (dst == null)
            {
                dst = new Menu();
            }

            dst.MenuId = src.MenuId;
            dst.MenuName = src.MenuName;

            return dst;
        }
    }
}
*/