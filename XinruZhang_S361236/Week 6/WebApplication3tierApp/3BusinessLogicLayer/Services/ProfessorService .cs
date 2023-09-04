

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class ProfessorService :  IProfessorService
    {
        private readonly IProfessorDal _ProfessorDal;
        //private readonly IProfessorBalService _ProfessorBalService;
        public ProfessorService(IProfessorDal ProfessorDal
        //ILoggingService loggingService,
        //IProfessorDal ProfessorDal,
        //IAuditDal auditDal
       // IProfessorBalanceService balsvc
        ) 
        {
            _ProfessorDal = ProfessorDal;
            // _ProfessorBalService = balsvc;
        }

        public async Task<ProfessorModel?> GetById(int ProfessorId)
        {           
            return _ProfessorDal.GetById(ProfessorId);
        }

        public async Task<List<ProfessorModel>> GetAll()
        {            
            return _ProfessorDal.GetAll();
        }

        public async Task<int> CreateProfessor(ProfessorModel Professor)
        {
            //write validations here
            var newProfessorId = _ProfessorDal.CreateProfessor(Professor);
            return newProfessorId;
        }

        public async Task UpdateProfessor(ProfessorModel Professor)
        {
            //write validations here 
            _ProfessorDal.UpdateProfessor(Professor);
        }

        public async Task DeleteProfessor(int ProfessorId)
        {            
            try
            {
                //if(balservice.getBal(ProfessorId) = 0)
                _ProfessorDal.DeleteProfessor(ProfessorId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Professor Id:{ProfessorId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
