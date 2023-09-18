using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IInstrumentService
    {
        Task<InstrumentModel?> GetById(int InstrumentId);
        Task<List<InstrumentModel>> GetAll();

        Task<int> CreateInstrument(InstrumentModel Instrument);
        Task UpdateInstrument(InstrumentModel Instrument);
        Task DeleteInstrument(int InstrumentId);
    }
}
