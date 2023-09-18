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
    public class BuildingDal : IBuildingDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public BuildingDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<BuildingModel> GetAll()
        {
            var result = _db.Buildings.ToList();

            var returnObject = new List<BuildingModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToBuildingModel());
            }

            return returnObject;
        }

        public BuildingModel? GetById(int BuildingId)
        {
            var result = _db.Buildings.SingleOrDefault(x => x.BuildingId == BuildingId);
            return result?.ToBuildingModel();
        }


        public int CreateBuilding(BuildingModel Building)
        {
            var newBuilding = Building.ToBuilding();
            _db.Buildings.Add(newBuilding);
            _db.SaveChanges();
            return newBuilding.BuildingId;
        }


        public void UpdateBuilding(BuildingModel Building)
        {
            var existingBuilding = _db.Buildings
                .SingleOrDefault(x => x.BuildingId == Building.BuildingId);

            if (existingBuilding == null)
            {
                throw new ApplicationException($"Building {Building.BuildingId} does not exist.");
            }
            Building.ToBuilding(existingBuilding);

            _db.Update(existingBuilding);
            _db.SaveChanges();
        }

        public void DeleteBuilding(int BuildingId)
        {
            var efModel = _db.Buildings.Find(BuildingId);
            _db.Buildings.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
