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
    public class ProfessorDal : IProfessorDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public ProfessorDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<ProfessorModel> GetAll()
        {
            var result = _db.Professors.ToList();

            var returnObject = new List<ProfessorModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToProfessorModel());
            }

            return returnObject;
        }

        public ProfessorModel? GetById(int ProfessorId)
        {
            var result = _db.Professors.SingleOrDefault(x => x.ProfessorId == ProfessorId);
            return result?.ToProfessorModel();
        }


        public int CreateProfessor(ProfessorModel Professor)
        {
            var newProfessor = Professor.ToProfessor();
            _db.Professors.Add(newProfessor);
            _db.SaveChanges();
            return newProfessor.ProfessorId;
        }


        public void UpdateProfessor(ProfessorModel Professor)
        {
            var existingProfessor = _db.Professors
                .SingleOrDefault(x => x.ProfessorId == Professor.ProfessorId);

            if (existingProfessor == null)
            {
                throw new ApplicationException($"Professor {Professor.ProfessorId} does not exist.");
            }
            Professor.ToProfessor(existingProfessor);

            _db.Update(existingProfessor);
            _db.SaveChanges();
        }

        public void DeleteProfessor(int ProfessorId)
        {
            var efModel = _db.Professors.Find(ProfessorId);
            _db.Professors.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
