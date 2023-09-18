

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class RegisterService :  IRegisterService
    {
        private readonly IRegisterDal _RegisterDal;
        //private readonly IRegisterBalService _RegisterBalService;
        public RegisterService(IRegisterDal RegisterDal
        //ILoggingService loggingService,
        //IRegisterDal RegisterDal,
        //IAuditDal auditDal
       // IRegisterBalanceService balsvc
        ) 
        {
            _RegisterDal = RegisterDal;
            // _RegisterBalService = balsvc;
        }

        public async Task<RegisterModel?> GetById(int RegisterId)
        {           
            return _RegisterDal.GetById(RegisterId);
        }

        public async Task<List<RegisterModel>> GetAll()
        {            
            return _RegisterDal.GetAll();
        }

        public async Task<int> CreateRegister(RegisterModel Register)
        {
            //write validations here
            var newRegisterId = _RegisterDal.CreateRegister(Register);
            return newRegisterId;
        }

        public async Task UpdateRegister(RegisterModel Register)
        {
            //write validations here 
            _RegisterDal.UpdateRegister(Register);
        }

        public async Task DeleteRegister(int RegisterId)
        {            
            try
            {
                //if(balservice.getBal(RegisterId) = 0)
                _RegisterDal.DeleteRegister(RegisterId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Student Id:{StudentId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
