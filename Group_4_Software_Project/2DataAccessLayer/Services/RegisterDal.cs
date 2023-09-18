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
    public class RegisterDal : IRegisterDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public RegisterDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<RegisterModel> GetAll()
        {
            var result = _db.Registers.ToList();

            var returnObject = new List<RegisterModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToRegisterModel());
            }

            return returnObject;
        }

        public RegisterModel? GetById(int RegisterId)
        {
            var result = _db.Registers.SingleOrDefault(x => x.RegisterId == RegisterId);
            return result?.ToRegisterModel();
        }


        public int CreateRegister(RegisterModel Register)
        {
            var newRegister = Register.ToRegister();
            _db.Registers.Add(newRegister);
            _db.SaveChanges();
            return newRegister.RegisterId;
        }


        public void UpdateRegister(RegisterModel Register)
        {
            var existingRegister = _db.Registers
                .SingleOrDefault(x => x.RegisterId == Register.RegisterId);

            if (existingRegister == null)
            {
                throw new ApplicationException($"Register {Register.RegisterId} does not exist.");
            }
            Register.ToRegister(existingRegister);

            _db.Update(existingRegister);
            _db.SaveChanges();
        }

        public void DeleteRegister(int RegisterId)
        {
            var efModel = _db.Registers.Find(RegisterId);
            _db.Registers.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
