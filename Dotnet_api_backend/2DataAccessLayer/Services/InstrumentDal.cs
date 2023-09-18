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
    public class InstrumentDal : IInstrumentDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public InstrumentDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<InstrumentModel> GetAll()
        {
            var result = _db.Instruments.ToList();

            var returnObject = new List<InstrumentModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToInstrumentModel());
            }

            return returnObject;
        }

        public InstrumentModel? GetById(int InstrumentId)
        {
            var result = _db.Instruments.SingleOrDefault(x => x.InstrumentId == InstrumentId);
            return result?.ToInstrumentModel();
        }


        public int CreateInstrument(InstrumentModel Instrument)
        {
            var newInstrument = Instrument.ToInstrument();
            _db.Instruments.Add(newInstrument);
            _db.SaveChanges();
            return newInstrument.InstrumentId;
        }


        public void UpdateInstrument(InstrumentModel Instrument)
        {
            var existingInstrument = _db.Instruments
                .SingleOrDefault(x => x.InstrumentId == Instrument.InstrumentId);

            if (existingInstrument == null)
            {
                throw new ApplicationException($"Instrument {Instrument.InstrumentId} does not exist.");
            }
            Instrument.ToInstrument(existingInstrument);

            _db.Update(existingInstrument);
            _db.SaveChanges();
        }

        public void DeleteInstrument(int InstrumentId)
        {
            var efModel = _db.Instruments.Find(InstrumentId);
            _db.Instruments.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
