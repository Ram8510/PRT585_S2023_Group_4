using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IInstrumentDal
    {
        // Getters
        InstrumentModel? GetById(int InstrumentId);
        List<InstrumentModel> GetAll();

        // Actions
        int CreateInstrument(InstrumentModel Instrument);
        void UpdateInstrument(InstrumentModel Instrument);
        void DeleteInstrument(int InstrumentId);
    }
}
