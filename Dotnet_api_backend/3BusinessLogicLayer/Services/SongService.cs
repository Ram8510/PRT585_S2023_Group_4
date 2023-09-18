

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class SongService :  ISongService
    {
        private readonly ISongDal _SongDal;
        //private readonly ISongBalService _SongBalService;
        public SongService(ISongDal SongDal
        //ILoggingService loggingService,
        //ISongDal SongDal,
        //IAuditDal auditDal
       // ISongBalanceService balsvc
        ) 
        {
            _SongDal = SongDal;
            // _SongBalService = balsvc;
        }

        public async Task<SongModel?> GetById(int SongId)
        {           
            return _SongDal.GetById(SongId);
        }

        public async Task<List<SongModel>> GetAll()
        {            
            return _SongDal.GetAll();
        }

        public async Task<int> CreateSong(SongModel Song)
        {
            //write validations here
            var newSongId = _SongDal.CreateSong(Song);
            return newSongId;
        }

        public async Task UpdateSong(SongModel Song)
        {
            //write validations here 
            _SongDal.UpdateSong(Song);
        }

        public async Task DeleteSong(int SongId)
        {            
            try
            {
                //if(balservice.getBal(SongId) = 0)
                _SongDal.DeleteSong(SongId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Song Id:{SongId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
