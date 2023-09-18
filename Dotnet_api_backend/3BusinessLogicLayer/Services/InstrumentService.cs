

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class InstrumentService :  IInstrumentService
    {
        private readonly IInstrumentDal _InstrumentDal;
        //private readonly IInstrumentBalService _InstrumentBalService;
        public InstrumentService(IInstrumentDal InstrumentDal
        //ILoggingService loggingService,
        //IInstrumentDal InstrumentDal,
        //IAuditDal auditDal
       // IInstrumentBalanceService balsvc
        ) 
        {
            _InstrumentDal = InstrumentDal;
            // _InstrumentBalService = balsvc;
        }

        public async Task<InstrumentModel?> GetById(int InstrumentId)
        {           
            return _InstrumentDal.GetById(InstrumentId);
        }

        public async Task<List<InstrumentModel>> GetAll()
        {            
            return _InstrumentDal.GetAll();
        }

        public async Task<int> CreateInstrument(InstrumentModel Instrument)
        {
            //write validations here
            var newInstrumentId = _InstrumentDal.CreateInstrument(Instrument);
            return newInstrumentId;
        }

        public async Task UpdateInstrument(InstrumentModel Instrument)
        {
            //write validations here 
            _InstrumentDal.UpdateInstrument(Instrument);
        }

        public async Task DeleteInstrument(int InstrumentId)
        {            
            try
            {
                //if(balservice.getBal(InstrumentId) = 0)
                _InstrumentDal.DeleteInstrument(InstrumentId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Instrument Id:{InstrumentId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
