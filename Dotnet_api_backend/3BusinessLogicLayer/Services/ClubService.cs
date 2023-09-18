

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class ClubService :  IClubService
    {
        private readonly IClubDal _ClubDal;
        //private readonly IClubBalService _ClubBalService;
        public ClubService(IClubDal ClubDal
        //ILoggingService loggingService,
        //IClubDal ClubDal,
        //IAuditDal auditDal
       // IClubBalanceService balsvc
        ) 
        {
            _ClubDal = ClubDal;
            // _ClubBalService = balsvc;
        }

        public async Task<ClubModel?> GetById(int ClubId)
        {           
            return _ClubDal.GetById(ClubId);
        }

        public async Task<List<ClubModel>> GetAll()
        {            
            return _ClubDal.GetAll();
        }

        public async Task<int> CreateClub(ClubModel Club)
        {
            //write validations here
            var newClubId = _ClubDal.CreateClub(Club);
            return newClubId;
        }

        public async Task UpdateClub(ClubModel Club)
        {
            //write validations here 
            _ClubDal.UpdateClub(Club);
        }

        public async Task DeleteClub(int ClubId)
        {            
            try
            {
                //if(balservice.getBal(ClubId) = 0)
                _ClubDal.DeleteClub(ClubId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Club Id:{ClubId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
