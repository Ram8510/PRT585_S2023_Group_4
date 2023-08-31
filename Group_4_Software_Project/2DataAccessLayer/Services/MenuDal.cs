using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class MenuDal : IMenuDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public MenuDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<MenuModel> GetAll()
        {
            var result = _db.Menus.ToList();

            var returnObject = new List<MenuModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToMenuModel());
            }

            return returnObject;
        }

        public MenuModel? GetById(int MenuId)
        {
            var result = _db.Menus.SingleOrDefault(x => x.MenuId == MenuId);
            return result?.ToMenuModel();
        }


        public int CreateMenu(MenuModel Menu)
        {
            var newMenu = Menu.ToMenu();
            _db.Menus.Add(newMenu);
            _db.SaveChanges();
            return newMenu.MenuId;
        }


        public void UpdateMenu(MenuModel Menu)
        {
            var existingMenu = _db.Menus
                .SingleOrDefault(x => x.MenuId == Menu.MenuId);

            if (existingMenu == null)
            {
                throw new ApplicationException($"Menu {Menu.MenuId} does not exist.");
            }
            Menu.ToMenu(existingMenu);

            _db.Update(existingMenu);
            _db.SaveChanges();
        }

        public void DeleteMenu(int MenuId)
        {
            var efModel = _db.Menus.Find(MenuId);
            _db.Menus.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
