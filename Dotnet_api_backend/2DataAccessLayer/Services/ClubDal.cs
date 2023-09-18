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
    public class ClubDal : IClubDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public ClubDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<ClubModel> GetAll()
        {
            var result = _db.Clubs.ToList();

            var returnObject = new List<ClubModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToClubModel());
            }

            return returnObject;
        }

        public ClubModel? GetById(int ClubId)
        {
            var result = _db.Clubs.SingleOrDefault(x => x.ClubId == ClubId);
            return result?.ToClubModel();
        }


        public int CreateClub(ClubModel Club)
        {
            var newClub = Club.ToClub();
            _db.Clubs.Add(newClub);
            _db.SaveChanges();
            return newClub.ClubId;
        }


        public void UpdateClub(ClubModel Club)
        {
            var existingClub = _db.Clubs
                .SingleOrDefault(x => x.ClubId == Club.ClubId);

            if (existingClub == null)
            {
                throw new ApplicationException($"Club {Club.ClubId} does not exist.");
            }
            Club.ToClub(existingClub);

            _db.Update(existingClub);
            _db.SaveChanges();
        }

        public void DeleteClub(int ClubId)
        {
            var efModel = _db.Clubs.Find(ClubId);
            _db.Clubs.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
