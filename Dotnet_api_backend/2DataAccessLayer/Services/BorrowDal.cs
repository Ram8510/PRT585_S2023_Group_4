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
    public class BorrowDal : IBorrowDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public BorrowDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<BorrowModel> GetAll()
        {
            var result = _db.Borrows.ToList();

            var returnObject = new List<BorrowModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToBorrowModel());
            }

            return returnObject;
        }

        public BorrowModel? GetById(int BorrowId)
        {
            var result = _db.Borrows.SingleOrDefault(x => x.BorrowId == BorrowId);
            return result?.ToBorrowModel();
        }


        public int CreateBorrow(BorrowModel Borrow)
        {
            var newBorrow = Borrow.ToBorrow();
            _db.Borrows.Add(newBorrow);
            _db.SaveChanges();
            return newBorrow.BorrowId;
        }


        public void UpdateBorrow(BorrowModel Borrow)
        {
            var existingBorrow = _db.Borrows
                .SingleOrDefault(x => x.BorrowId == Borrow.BorrowId);

            if (existingBorrow == null)
            {
                throw new ApplicationException($"Borrow {Borrow.BorrowId} does not exist.");
            }
            Borrow.ToBorrow(existingBorrow);

            _db.Update(existingBorrow);
            _db.SaveChanges();
        }

        public void DeleteBorrow(int BorrowId)
        {
            var efModel = _db.Borrows.Find(BorrowId);
            _db.Borrows.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
