

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class BuildingService :  IBuildingService
    {
        private readonly IBuildingDal _BuildingDal;
        //private readonly IBuildingBalService _BuildingBalService;
        public BuildingService(IBuildingDal BuildingDal
        //ILoggingService loggingService,
        //IBuildingDal BuildingDal,
        //IAuditDal auditDal
       // IBuildingBalanceService balsvc
        ) 
        {
            _BuildingDal = BuildingDal;
            // _BuildingBalService = balsvc;
        }

        public async Task<BuildingModel?> GetById(int BuildingId)
        {           
            return _BuildingDal.GetById(BuildingId);
        }

        public async Task<List<BuildingModel>> GetAll()
        {            
            return _BuildingDal.GetAll();
        }

        public async Task<int> CreateBuilding(BuildingModel Building)
        {
            //write validations here
            var newBuildingId = _BuildingDal.CreateBuilding(Building);
            return newBuildingId;
        }

        public async Task UpdateBuilding(BuildingModel Building)
        {
            //write validations here 
            _BuildingDal.UpdateBuilding(Building);
        }

        public async Task DeleteBuilding(int BuildingId)
        {            
            try
            {
                //if(balservice.getBal(BuildingId) = 0)
                _BuildingDal.DeleteBuilding(BuildingId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Building Id:{BuildingId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
